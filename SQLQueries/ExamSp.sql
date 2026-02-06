-- Exam generation
-- return 1 when success
-- return -1 when no course with this name is found
-- return -2 if duration validation is incorrect
use ITIExaminationSystem2

sp_examGeneration 1003,10,5,60
go

create or alter proc sp_examGeneration @course_id int, @no_of_qus int, @mcq_qus int, @ex_duartion int
as
begin
	declare @other_qus int
	declare @exam_no int

    set @other_qus = @no_of_qus - @mcq_qus

	select crs_id 
	from course 
	where crs_id = @course_id

    if not exists (
        select 1
        from course
        where crs_id = @course_id
    )
        return -1

    if @ex_duartion < 20 or @ex_duartion > 240
        return -2

    if @no_of_qus < @mcq_qus
        return -3

    if @no_of_qus<0 or @mcq_qus < 0
        return -4
	if exists (select 1 from exam 
		where crs_id=@course_id and ex_date=CAST(GETDATE() AS DATE)
		)
		return -6
begin try
    begin transaction;
    insert into exam (ex_duration, ex_date, crs_id)
    values (@ex_duartion, getdate(), @course_id)

	set @exam_no = scope_identity()

	insert into exam_question (ex_no, qus_no)
    select top (@mcq_qus) @exam_no, q.qus_no
    from course_question cq
    join question q on q.qus_no = cq.qus_no
    where cq.crs_id = @course_id
      and q.qus_type = 1
    order by newid()

    insert into exam_question (ex_no, qus_no)
    select top (@other_qus) @exam_no, q.qus_no
    from course_question cq
    join question q on q.qus_no = cq.qus_no
    where cq.crs_id = @course_id
      and q.qus_type != 1
    order by newid()

    commit transaction;
	return 1
end try
begin catch
    rollback transaction;
    return -5;
end catch
end
go

exec sp_examGeneration 1000, 10, 5, 90

go


--	Exam Correction
-- return -1 exam not found
-- return -2 student not found
-- return -3 exam has no questions
--  return -4 any unexpected errors

GO
/****** Object:  StoredProcedure [dbo].[sp_examcorrection]    Script Date: 2/5/2026 2:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[sp_examcorrection]
    @ex_no INT,
    @std_id INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE 
        @total_questions INT,
        @correct_answers INT,
        @grade DECIMAL(5,2);

    BEGIN TRY
        -- check exam exists
        IF NOT EXISTS (SELECT 1 FROM exam WHERE ex_no = @ex_no)
            RETURN -1;  -- exam not found

        -- get student id from user id

        IF @std_id IS NULL
            RETURN -2;  -- student not found for this user

        -- total questions in exam
        SELECT @total_questions = COUNT(*)
        FROM exam_question
        WHERE ex_no = @ex_no;

        IF @total_questions = 0
            RETURN -3;  -- exam has no questions

        -- correct answers count
        SELECT @correct_answers = COUNT(*)
        FROM student_exam_ans sea
        JOIN question q
            ON sea.qus_no = q.qus_no
		JOIN choice c On c.choice_id=sea.choice_id
        WHERE sea.ex_no = @ex_no
          AND sea.std_id = @std_id
          AND c.choice_text = q.correct_answer;

        -- calculate grade
        SET @grade = (@correct_answers * 100.0) / @total_questions;

        -- insert or update grade
        IF EXISTS (
            SELECT 1
            FROM student_exam_grade
            WHERE ex_no = @ex_no AND std_id = @std_id
        )
            UPDATE student_exam_grade
            SET grade = @grade
            WHERE ex_no = @ex_no AND std_id = @std_id;
        ELSE
            INSERT INTO student_exam_grade (ex_no, std_id, grade)
            VALUES (@ex_no, @std_id, @grade);

        -- return grade
        SELECT @grade AS grade;

        RETURN 1; -- success
    END TRY
    BEGIN CATCH
        RETURN -4; -- unexpected error
    END CATCH
END;
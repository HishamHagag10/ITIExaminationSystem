select * from student 
-- edited sp_SelectCoursesForStudent       @id ==userid
go
	CREATE OR ALTER PROC [dbo].[sp_SelectCoursesForStudent]
(
    @id INT
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM student WHERE user_id = @id)
    BEGIN
        -- Return an empty result set instead of just -1
        SELECT CAST(NULL AS INT) AS Id, CAST(NULL AS NVARCHAR(100)) AS Name WHERE 1=0;
        RETURN -1;
    END

    SELECT
        c.crs_id AS Id,
        c.crs_name AS Name
    FROM student s
    INNER JOIN course c ON s.track_id = c.track_id
    WHERE s.user_id = @id;

    RETURN 1;
END
go
 exec [sp_SelectCoursesForStudent] 15
 go
 -----------------------------------------------------------

 exec TakeExam  1000
 exec sp_examGeneration 1000,10,7,80

 go
 select * from student
 go
 --getStudentExamAnswers
----------------------------edited -----------------------
CREATE OR ALTER PROC [dbo].[sp_SelectStudentExamAnswers]
(
    @std_id INT
)
AS
BEGIN
    
    IF NOT EXISTS (SELECT 1 FROM student WHERE user_id = @std_id)
        RETURN -1;

    SELECT 
        sa.qus_no,
        q.qus_text,
        c.choice_text AS student_answer,
        q.correct_answer AS correct_answer,
        CASE 
            WHEN c.choice_text = q.correct_answer THEN 'Correct'
            ELSE 'Wrong'
        END AS result
    FROM student_exam_ans sa
    INNER JOIN question q ON sa.qus_no = q.qus_no
	INNER JOIN choice c ON c.choice_id=sa.choice_id
    WHERE sa.std_id = @std_id
    ORDER BY sa.qus_no;

    RETURN 1;
END

go

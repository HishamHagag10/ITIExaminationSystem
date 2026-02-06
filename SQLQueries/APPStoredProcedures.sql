
use ITIExaminationSystem2

GO

create or alter proc sp_SelectTracks
as
begin
	select track_id,track_name from track
	return 1
end

GO

Create or alter Proc sp_SelectCourses
as
begin
	select crs_id,crs_name,track_id,ins_id from course;
	return 1;
end

GO

GO

ALTER   proc [dbo].[sp_SelectStudents]
as
begin
	select s.user_id as Id,s.std_first_name+' '+s.std_last_name as FullName,
	s.std_phoneno as Phone,s.track_id as TrackId ,u.is_active 
	from student s  inner join user_account u on u.user_id=s.user_id ;
	return 1;
end

GO

ALTER   proc [dbo].[sp_SelectInstructors]
as
begin
	select i.user_id as Id,i.ins_name as Name,
	i.ins_phoneno as Phone,i.ins_email as Email , i.ins_salary as Salary ,u.is_active 
	from instructor i inner join user_account u on i.user_id=u.user_id
	return 1;
end


GO

Create or alter proc sp_UpdateStudent(
    @user_id       INT,
    @std_phoneno   VARCHAR(20)    = NULL,
    @std_first_name VARCHAR(50)   = NULL,
    @std_last_name  VARCHAR(50)   = NULL,
    @std_email     VARCHAR(100)   = NULL,
    @std_city      VARCHAR(50)    = NULL,
    @std_street    VARCHAR(100)   = NULL,
    @std_zipcode   VARCHAR(10)    = NULL,
    @std_gender    CHAR(1)        = NULL,
    @std_age       INT            = NULL,
    @track_id      INT            = NULL)
AS
BEGIN
	if not exists(select 1 from user_account 
				where user_id=@user_id and is_active=1)
			return -1
    SET NOCOUNT ON;
	UPDATE student
    SET
        std_phoneno    = ISNULL(@std_phoneno, std_phoneno),
        std_first_name = ISNULL(@std_first_name, std_first_name),
        std_last_name  = ISNULL(@std_last_name, std_last_name),
        std_email      = ISNULL(@std_email, std_email),
        std_city       = ISNULL(@std_city, std_city),
        std_street     = ISNULL(@std_street, std_street),
        std_zipcode    = ISNULL(@std_zipcode, std_zipcode),
        std_gender     = ISNULL(@std_gender, std_gender),
        std_age        = ISNULL(@std_age, std_age),
        track_id       = ISNULL(@track_id, track_id)
    WHERE user_id = @user_id;

    -- return status
    IF @@ROWCOUNT = 0
        RETURN -1; -- student not found

    RETURN 1; -- success
END
GO


Create or alter PROCEDURE sp_UpdateInstructor
    @user_id int,
    @ins_name varchar(100),
    @ins_gender char(1),
    @ins_phoneNo varchar(20),
    @ins_email varchar(100),
    @ins_salary decimal(10,2),
    @ins_dob date,
    @ins_city varchar(50),
    @ins_street varchar(100)
AS
BEGIN
	if not exists(select 1 from user_account 
				where user_id=@user_id and is_active=1)
			return -1
    SET NOCOUNT ON;
    UPDATE dbo.instructor
    SET 
        ins_name = @ins_name,
        ins_gender = @ins_gender,
        ins_phoneNo = @ins_phoneNo,
        ins_email = @ins_email,
        ins_salary = @ins_salary,
        ins_dob = @ins_dob,
        ins_city = @ins_city,
        ins_street = @ins_street
    WHERE 
        user_id = @user_id;
	 -- return status
    IF @@ROWCOUNT = 0
        RETURN -1; -- student not found

    RETURN 1; -- success
END
GO


Create or alter proc sp_SelectStudent @id int
as
begin
    if exists(select 1 from user_account 
				where user_id=@id and is_active=1)
        begin
            select s.user_id, s.std_first_name, s.std_last_name, s.std_email, s.std_phoneno, s.std_city, s.std_street, 
                    s.std_zipcode, s.std_gender, s.std_age, s.track_id, u.user_name, u.pass
            from student s join user_account u 
            on s.user_id = u.user_id
            where s.user_id = @id

            return 1
        end
    else
        return -4
end

GO

Create or alter proc sp_SelectInstructor @id int
as
begin
    if not exists(select 1 from user_account 
				where user_id=@id and is_active=1)
		begin
            select i.user_id, i.ins_name, i.ins_gender, i.ins_email, i.ins_phoneNo, 
                i.ins_salary, i.ins_dob, i.ins_city, i.ins_street, u.user_name, u.pass
            from instructor i join user_account u 
            on i.user_id = u.user_id
            where i.user_id = @id

            return 1
        end
    else
        return -4
end


go

create or alter proc  sp_Selectinstructorwithcourses  @id int  
 as 
 begin 
		select crs_id,crs_name from instructor i inner join course c 
		on i.user_id=c.ins_id
			where i.user_id=@id
end
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

GO

CREATE OR ALTER PROCEDURE sp_TakeExam
    @crsid INT
AS
BEGIN
    SELECT
        e.ex_no,
        q.qus_no,
        q.qus_text,
		q.qus_type,
		STRING_AGG(c.choice_id, ',') WITHIN GROUP (ORDER BY c.choice_id) AS choicesId,
        STRING_AGG(c.choice_text, ',') WITHIN GROUP (ORDER BY c.choice_id) AS choices   
		FROM Exam e
		INNER JOIN Exam_Question eq ON e.ex_no = eq.ex_no
		INNER JOIN Question q ON q.qus_no = eq.qus_no
		INNER JOIN Choice c ON c.qus_no = q.qus_no
		WHERE e.crs_id = @crsid
		AND CAST(e.ex_date AS DATE) = CAST(GETDATE() AS DATE)
		GROUP BY e.ex_no, q.qus_no, q.qus_text, q.qus_type
		ORDER BY q.qus_no
END



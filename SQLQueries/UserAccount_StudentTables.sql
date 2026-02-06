--return 1 success
--return -1 if user_name or pass Not found (Login_Sp)
--return -2 if id is incorrect or id belongs to ins cannot be deleted (deleteStudent)
--return -3 if id is incorrect or id belongs to std cannot be deleted (deleteInstructor)
--return -4 if id is incorrect (selectStudent & selectInstrcutor & sp_ReportStudentsByTrack)
USE ITIExaminationSystem2
GO

--Login Sp takes User Name and Password and Return User id(std id or ins id) and role
create or alter proc sp_login (@user_name varchar(50), @pass varchar(200))
as
begin
	set nocount on
	if exists(select 1 from user_account
			where user_name = @user_name and 
			pass = @pass and is_active=1)
			begin
				select user_id as id, role
				from user_account
				where user_name = @user_name and pass = @pass
                return 1
			end
	else
		return -1
end

exec sp_login "student", "pass"

GO

--insertStudent
create or alter proc sp_CreateStudent (
    @user_name varchar(50),
    @pass varchar(200),
    @std_first_name varchar(50),
    @std_last_name varchar(50),
    @std_email varchar(100),
    @std_phoneno varchar(20),
    @std_city varchar(50),
    @std_street varchar(100),
    @std_zipcode varchar(10),
    @std_gender char(1),
    @std_age int,
    @track_id int)
as
begin
	if exists (select 1 from user_account 
			where user_name=@user_name)
		return -1
	begin try
		begin transaction;
		insert into user_account(user_name, pass, role)
		values(@user_name, @pass, 0)

		declare @user_id int = scope_identity()

		insert into student(user_id, std_first_name, std_last_name, std_email, std_phoneno, std_city, std_street, std_zipcode, std_gender, std_age, track_id)
		values(@user_id, @std_first_name, @std_last_name, @std_email, @std_phoneno, @std_city, @std_street, @std_zipcode, @std_gender, @std_age, @track_id)
		commit transaction;
	end try 
	begin catch 
		rollback transaction;
		return -2
	end catch
    return 1
end

exec sp_CreateStudent
    @user_name = 'john_doe',
    @pass = 'Password123',
    @std_first_name = 'John',
    @std_last_name = 'Doe',
    @std_email = 'john.doe@example.com',
    @std_phoneno = '1234567890',
    @std_city = 'New York',
    @std_street = '123 Main St',
    @std_zipcode = '10001',
    @std_gender = 'M',
    @std_age = 20,
    @track_id = 1;



--deleteStudent By Id
-- run it
GO
create or alter proc sp_DeleteStudent @id int
as
begin
    if exists(select 1 from user_account
            where user_id = @id and is_active=1)
        begin
            update user_account 
				set is_active=0
				where user_id = @id
            return 1
        end
    else
        return -2
end

GO

exec sp_deleteStudent 16


--selectStudent by id
GO
create or alter proc sp_SelectStudent @id int
as
begin
    if exists(select 1 from user_account where user_id = @id)
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

exec sp_SelectStudent 1


GO
--insertInstructor
create or alter proc sp_CreateInstructor(
    @user_name varchar(50),
    @pass varchar(200),
    @ins_name varchar(100),
    @ins_gender char(1),
    @ins_phoneNo varchar(20),
    @ins_email varchar(100),
    @ins_salary decimal(10,2),
    @ins_dob date,
    @ins_city varchar(50),
    @ins_street varchar(100))
as
begin
	if exists (select 1 from user_account where user_name=@user_name)
		return -1
	BEGIN TRY
		BEGIN TRANSACTION;
			insert into user_account(user_name, pass, role)
			values(@user_name, @pass, 1)

			declare @user_id int = scope_identity()

			insert into instructor(user_id, ins_name, ins_gender, ins_phoneNo, ins_email, ins_salary, ins_dob, ins_city, ins_street)
			values (@user_id, @ins_name, @ins_gender, @ins_phoneNo, @ins_email, @ins_salary, @ins_dob, @ins_city, @ins_street)
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		return -1
	END CATCH
    return 1
end

exec sp_CreateInstructor
    @user_name = 'prof_smith',
    @pass = 'Pass456',
    @ins_name = 'Dr. Smith',
    @ins_gender = 'M',
    @ins_phoneNo = '9876543210',
    @ins_email = 'smith@example.com',
    @ins_salary = 8000,
    @ins_dob = '1980-05-15',
    @ins_city = 'Los Angeles',
    @ins_street = '456 Elm St';


--deleteInstructor By Id
-- run it 
GO
create or alter proc sp_DeleteInstructor @id int
as
begin
    if exists(select 1 from user_account where 
				user_id = @id and is_active=1)
        begin
            update user_account 
				set is_active=0
				where user_id = @id
            return 1
        end
    else
        return -3
end

exec sp_DeleteInstructor 5


GO
--selectInstructor by id
create or alter proc sp_SelectInstructor @id int
as
begin
    if exists(select 1 from user_account 
				where user_id = @id)
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

exec sp_SelectInstructor  3

GO
--sp_ReportStudentsByTrack by track_id
create or alter proc sp_ReportStudentsByTrack @trackId int
as
begin
    if exists(select 1 from student s join user_account u
				on u.user_id=s.user_id 
				where track_id = @trackId)
        begin
            select s.user_id, s.std_first_name, s.std_last_name, u.user_name, s.std_email
            from student s
            join user_account u
            on s.user_id = u.user_id
            where s.track_id = @trackId

            return 1
        end
    else
        return -4
end


exec sp_ReportStudentsByTrack 3
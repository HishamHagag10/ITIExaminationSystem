use itiexaminationsystem2
GO

--sp createExam 
-- -1 exam duration invalid
-- -2 invalid date
-- -3 course not found
create or alter proc sp_createExam @ex_dur int, @ex_dat date, @crs_id int
as
	if( @ex_dur<=0 or @ex_dur > 5)
		return -1
	if(@ex_dat < cast(GETDATE() as date))
		return -2
	if(not exists(select crs_id from course where crs_id = @crs_id))
		return -3
	insert into exam values(@ex_dur,@ex_dat,@crs_id)
	return 1

go

sp_createExam 3,'1-21-2026',1000
go

-- sp updateExam
-- -1 exam number not found
-- -2 exam duration invalid
-- -3 course not found

create or alter procedure sp_updateExam @ex_id int , @ex_dur int=NULL, @ex_dat date =NULL ,@crs_id int=NULL
with encryption
as
	if(not exists(select ex_no from exam where ex_no = @ex_id))
		return -1
		if( @ex_dur<0 or @ex_dur > 5)
		return -2
	if(@crs_id is not null)
	begin
		if(not exists(select crs_id from course where crs_id = @crs_id))
			return -3
		update exam set crs_id = @crs_id where ex_no = @ex_id
	end
	if(@ex_dur is not null)
		update exam set ex_duration = @ex_dur where ex_no=@ex_id
	if(@ex_dat is not null)
		update exam set ex_date = @ex_dat where ex_no = @ex_id
	return 1

go
sp_updateExam 4,4,'1-1-2027',1000
go

--sp getExams
-- -1 no exams found
create or alter proc sp_getExams
as
	if(not exists (select ex_no from exam))
		return -1
	select * from exam
	return 1
go

sp_getExams

go

-- sp getExambyno
-- -1 exam number not found
create or alter proc sp_getExamByNo @ex_no int
as
	if(not exists(select ex_no from exam where @ex_no=ex_no))
		return -1
	select * from exam where ex_no=@ex_no
	return 1

go

sp_getExamByNo 4

go

-- sp getCourseExams
-- -1 no exams for this course
create or alter proc sp_getCourseExams @crs_id int
as
	if(not exists(select ex_no from exam where crs_id = @crs_id))
		return -1
	select * from exam where crs_id = @crs_id
	return 1

go

sp_getCourseExams 1000

go

-- sp deleteExam
-- -1 exam number not found
create or alter proc sp_deleteExam @ex_no int
with encryption
as 
	if(not exists(select ex_no from exam where @ex_no = ex_no))
		return -1
	delete from exam where @ex_no = ex_no
	return 1


go

sp_deleteExam 5
GO
-- sp deleteCourseExams
create or alter proc sp_deleteCourseExams @crs_id int
with encryption
as
	delete from exam where crs_id = @crs_id
	return 1

go

sp_deleteCourseExams 1001

go
---------------------------------------------------------------------------------
-- sp_getQuestions
create or alter proc sp_getQuestions
as
	select * from question 
	return 1


go

sp_getQuestions

GO
--sp_getMCQQuestions
create or alter proc sp_getMCQQuestions
as
	select * from question where qus_type = 1
	return 1

GO

sp_getMCQQuestions

GO

-- sp_getTFQuestions
create or alter proc sp_getTFQuestions
as
	select * from question where qus_type = 0
	return 1

GO

sp_getTFQuestions

GO

-- sp_getQuestionByNo
-- -1 question number not found
create or alter proc sp_getQuestionByNo @qus_no int
as
	if(not exists(select qus_no from question where @qus_no = qus_no))
		return -1
	select * from question where qus_no = @qus_no
	return 1

GO
sp_getQuestionByNo 13

GO
-- sp_addQuestion
-- -1 not created
-- -2 wrong qus_type
create or alter proc sp_addQuestion @qus_text varchar(200), @qus_type bit, @correct_ans varchar(200)
with encryption
as
	insert into question values(@qus_text,@qus_type,@correct_ans)
	if (@@ROWCOUNT > 0)
		return 1
	else
		return -1

go

sp_addQuestion 'DB is abbreviation for DataBase',0,'T'

go

-- sp_UpdateQuestion
-- -1 question id not found

create or alter proc sp_updateQuestion 
@qus_no int, @qus_text varchar(200), @qus_type bit, @correct_ans varchar(200)
with encryption
as
	if(not exists(select qus_no from question where qus_no = @qus_no))
		return -1
	update question set qus_text=@qus_text,qus_type=@qus_type, correct_answer=@correct_ans
	where qus_no = @qus_no
	return 1

go

sp_updateQuestion 11,'DB is abbreviation for DataBase Course',0,'T'

go

--sp_getQuestionsByCourse
-- -1 course id not found
create or alter proc sp_GetQuestionsByCourse @crs_id int
as
	if(not exists(select crs_id from course where crs_id=@crs_id))
		return -1
	select * from question q inner join course_question cq on q.qus_no=cq.qus_no where crs_id = @crs_id
	return 1

go

sp_getQuestionsByCourse 1000


-- sp_deleteQuestion 
-- -1 question id not found
GO

create or alter proc sp_deleteQuestion @qus_id int
as
	if (not exists(select * from question where qus_no = @qus_id))
		return -1
	delete from question where qus_no = @qus_id
	return 1


go

sp_deleteQuestion 11


----------------------------------------------------------------------------------------
--choice storeds

select * from choice
select * from exam_question

GO
--sp_getChoices
create or alter proc sp_getChoices
as
	select * from choice
	return 1

go

sp_getChoices

GO
--sp_getQuesetionChoices
-- -1 question id not found
create or alter proc sp_getQuestionChoices @qus_id int
as 
	if(not exists(select qus_no from question where qus_no=@qus_id))
		return -1
	select * from choice where @qus_id=qus_no
	return 1

go

sp_getQuestionChoices 1

go

-- sp_createChoice
-- -1 question id not found
create or alter proc sp_createChoice @qus_id int,@choice varchar(200)
with encryption
as
	if(not exists(select qus_no from question where qus_no=@qus_id))
		return -1
	insert into choice values(@qus_id,@choice)
	return 1

go

sp_createChoice 5,'None of them'

go

--sp_updateChoice
-- -1 choice id not found
-- -2 question id not found
create or alter proc sp_updateChoice @choice_id int,@qus_id int,@choice varchar(200)=NULL
with encryption
as
	if(not exists(select choice_id from choice where choice_id=@choice_id))
		return -1
	if(not exists(select qus_no from question where qus_no=@qus_id))
		return -2
	if(@choice != NULL)
		update choice set choice_text = @choice where @choice_id = choice_id
	update choice
	set qus_no = @qus_id 
	where @choice_id = choice_id
	return 1

go

sp_updateChoice 1,1,'Proramming Language'

go

--sp_deleteChoice
-- -1 choice id not found
create or alter proc sp_deleteChoice
@choice_id int
with encryption
as
	if(not exists(select choice_id from choice where choice_id=@choice_id))
		return -1
	delete from choice where choice_id=@choice_id
	return 1

GO
sp_deleteChoice 5
GO

------------------------------------------------------------------------------------------------
--exam_question storeds

--sp_addQuestionToExam
-- -1 Exam id not found
-- -2 Question id not found
-- -3 Question is already added
-- -4 Exam has 10 questions
-- -5 this question does not belong the course of this exam
GO
create or alter proc sp_addQuestionToExam
@qus_id int,@exam_id int
with encryption
as
	if(not exists(select ex_no from exam where ex_no=@exam_id))
		return -1
	if(not exists(select qus_no from question where qus_no=@qus_id))
		return -2
	if(exists (select ex_no from exam_question where ex_no=@exam_id and qus_no = @qus_id))
		return -3
	if((select count(ex_no) from exam_question where ex_no=@exam_id) >= 10)
		return -4
	declare @crs_id int
	select @crs_id = crs_id from exam where ex_no=@exam_id
	if(not exists(select qus_no from course_question where crs_id=@crs_id and qus_no=@qus_id))
		return -5

	insert into exam_question values(@exam_id,@qus_id)
	return 1

go

sp_addQuestionToExam 8,4

go

--sp_removeQuestionFromExam
-- -1 Exam id not found
-- -2 Question id not found

create or alter proc sp_removeQuestionFromExam @qus_no int,@ex_no int
with encryption
as
	if(not exists(select ex_no from exam where ex_no=@ex_no))
		return -1
	if(not exists(select qus_no from question where qus_no=@qus_no))
		return -2
	delete from exam_question where qus_no=@qus_no and ex_no=@ex_no
	return 1

go

sp_removeQuestionFromExam 10,4

go

--sp_getExamQuestions
-- -1 exam id not found

create or alter proc sp_getExamQuestions 
@ex_no int
as
	if(not exists(select ex_no from exam where ex_no = @ex_no))
		return -1
	select ex_no,q.qus_no,qus_text,qus_type,
	STRING_AGG(c.choice_text, ',') AS choices,correct_answer
	from question q 
	join exam_question eq on eq.qus_no=q.qus_no 
	join choice c on c.qus_no=q.qus_no
	where eq.ex_no=@ex_no
	group by ex_no,q.qus_no,qus_text,qus_type,correct_answer
	return 1

go

sp_getExamQuestions 4

go
--sp_getAllExamsQuestions
create or alter proc sp_getAllExamsQuestions
as
	select * from exam_question

go

sp_getAllExamsQuestions

GO

---------------------------------------------------------------------------------------------------
--course_question table
--sp_getAllCoursesQuestions
create or alter proc sp_getAllCoursesQuestions
as
	select  * from course_question
	return 1

go

sp_getAllCoursesQuestions

--sp_getCourseQuestions
-- -1 course id not found
GO

create or alter proc sp_getCourseQuestions @crs_id int
as
	if(not exists(select 1 from course where crs_id=@crs_id))
		return -1
	select crs_id from course_question where crs_id=@crs_id
	return 1

go

sp_getCourseQuestions 1

go

--sp_addQuestionToCourse
-- -1 question id not found
-- -2 course id not found
create or alter proc sp_addQuestionToCourse @qus_no int, @crs_id int
as
	if(not exists(select 1 from question where qus_no=@qus_no))
		return -1
	if(not exists(select 1 from course where crs_id=@crs_id))
		return -2
	if(exists(select 1 from course_question where qus_no=@qus_no and crs_id=@crs_id))
		return -3
	insert into course_question values (@crs_id,@qus_no)
	return 1	


go

-- -3 question already added to course
sp_addQuestionToCourse 10,1000

--sp_removeQuestionFromCourse
-- -1 question id not found
-- -2 course id not found
-- -3 question is not assigned to this course
GO

create or alter proc sp_removeQuestionFromCourse @qus_no int, @crs_id int
with encryption
as
	if(not exists(select 1 from question where qus_no=@qus_no))
		return -1
	if(not exists(select 1 from course where crs_id=@crs_id))
		return -2
	if(exists(select 1 from course_question where qus_no=@qus_no and crs_id=@crs_id))
		return -3
	delete from course_question where qus_no=@qus_no and crs_id=@crs_id
	return 1

go
sp_removeQuestionFromCourse 10,1000
go

--------------------------------------------------------
--sp_examQuestions
-- -1 no exam found
sp_getexamQuestions 4

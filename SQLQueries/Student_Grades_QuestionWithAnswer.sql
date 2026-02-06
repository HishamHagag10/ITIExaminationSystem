--=============================================================================================================
 --=================================================report====================================================
--=======================================FOURTH REPORT=========================================================				
--Report that takes exam number and the student ID then returns 
--the Questions in this exam with the student answers.
USE ITIExaminationSystem2

GO
CREATE or alter  PROC sp_Report_QuestionWithAnswer 
@examNo int,@stid int
AS
Begin
select q.qus_text as QuestionText,c.choice_text as  AnswerText,qa.choice_id as choiceId
from question q 
left join  student_exam_ans qa on q.qus_no=qa.qus_no and qa.ex_no=@examNo and qa.std_id=@stid
left join choice c on c.choice_id=qa.choice_id
end 
GO
Exec sp_Report_QuestionWithAnswer  2,2

--=========================================================================================================
-----------------------------------SEC REPORT----------------------------------------------------------------
 --Report that takes the student ID and returns
 --the grades of the student in all courses. %
GO
create or Alter  proc sp_Report_Student_Grades   @stid int
as
begin
select c.crs_name As CourseName, CAST(sg.grade AS DECimal(5,2) ) AS [Grade %]
from student_exam_grade sg  inner join exam e
on e.ex_no=sg.ex_no
inner join course c on c.crs_id=e.crs_id 
where sg.std_id=@stid
end
GO
EXEC sp_Report_Student_Grades  31

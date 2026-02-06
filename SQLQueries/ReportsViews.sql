use ITIExaminationSystem2

go

---report 4 
create or alter view vw_courseTopics
as
	select c.crs_id ,crs_name , track_id , ins_id,t.topic_id,t.topic_name from course c
	left join crs_topic ct on c.crs_id=ct.crs_id
	left join topic t on t.topic_id=ct.topic_id

go


--report 5 old version
--create or alter view vw_examQuestionsChoices
--as
--	select e.ex_no,c.crs_name,q.qus_no,q.qus_text,q.qus_type,ch.choice_text , q.correct_answer
--	from exam e inner join exam_question eq on e.ex_no=eq.ex_no
--	inner join course c on e.crs_id=c.crs_id
--	inner join question q on q.qus_no=eq.qus_no
--	inner join choice ch on ch.qus_no=e.ex_no
--
--go


create or alter view vw_examQuestionsChoices
as
	select eq.ex_no, k.qus_no,k.qus_text,k.qus_type,k.correct_answer,
	max(case when k.choice_num=1 then k.choice_text end) as 'Option A',
	max(case when k.choice_num=2 then k.choice_text end) as 'Option B',
	max(case when k.choice_num=3 then k.choice_text end) as 'Option C',
	max(case when k.choice_num=4 then k.choice_text end) as 'Option D'
	from exam_question eq 
	inner join
	(select q.qus_no,q.qus_text,q.qus_type,q.correct_answer,c.choice_text,
	ROW_NUMBER() over(partition by q.qus_no order by q.qus_no) as choice_num
	from question q
	inner join choice c on c.qus_no=q.qus_no) as k
	on eq.qus_no=k.qus_no
	group by
	eq.ex_no,
	k.qus_no,
	k.qus_text,
	k.qus_type,
	k.correct_answer

go

select * from vw_examQuestionsChoices

go

--report 6
create or alter view vw_studentExamAnswers
as
	select s.user_id,CONCAT(s.std_first_name , ' ' , s.std_last_name) as 'full name',s.track_id,
	sea.ex_no,sea.qus_no,q.qus_text,q.qus_type,c.choice_text as 'student answer' 
	from student s 
	left join student_exam_ans sea on sea.std_id=s.user_id 
	left join question q on q.qus_no=sea.qus_no
	left join choice c on c.choice_id = sea.choice_id


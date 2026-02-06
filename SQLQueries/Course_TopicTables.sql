--2
--track
--course
--topic
--crs_topic
use ITIExaminationSystem2;

--- Course Table
--- return  1  Success
--- return -1 no course with crs_id
--- return -2 no instructor with ins_id
--- return -3 no track with track_id

GO

create or alter proc sp_CreateCourse(
				@crs_name varchar(100),
				@ins_id int,
				@track_id int)
as
begin
	if @ins_id is not null 
		and not exists (select 1 from instructor ins 
						join user_account u
						on ins.user_id=u.user_id
						where ins.user_id=@ins_id and is_active=1)
		return -1
	if not exists (select 1 from track 
						where track_id=@track_id)
		return -3
	insert into course (crs_name,ins_id,track_id) 
				values (@crs_name,@ins_id,@track_id)
	return 1
end

GO

create or alter proc sp_UpdateCourse(
				@crs_id int,
				@crs_name varchar(100),
				@ins_id int,
				@track_id int
				)
as
begin
	if not exists (select 1 from course 
					     where crs_id=@crs_id)
		return -1
	if @ins_id is not null 
		and not exists (select 1 from instructor ins 
						join user_account u
						on ins.user_id=u.user_id
						where ins.user_id=@ins_id and is_active=1)
		return -2
	if not exists (select 1 from track 
						where track_id=@track_id)
		return -3
	update course 
		set crs_name = ISNULL(@crs_name,crs_name),
			ins_id   = @ins_id,
			track_id = @track_id
		where crs_id=@crs_id
	return 1
end

GO
create or alter proc sp_DeleteCourse(
@crs_id int)
as
begin
	if not exists (select 1 from course 
					     where crs_id=@crs_id)
		return -1
	delete from course
			where crs_id=@crs_id
	return 1
end

GO
create or alter proc sp_SelectCourse(
				@crs_id int)
as
begin
	if not exists (select 1 from course 
					     where crs_id=@crs_id)
		return -1
	select * from course
			where crs_id=@crs_id
	return 1
end

GO
create or alter proc sp_SelectTrackCourses(
					@track_id int)
as
begin	
	if not exists (select 1 from track 
					     where track_id=@track_id)
		return -3
	select crs_id , crs_name 
		from course  where Track_id=@track_id
	return 1
end


exec sp_CreateCourse 'course1',1,1010
exec sp_SelectCourse 1000
exec sp_UpdateCourse 1010,'course',1,10
exec sp_DeleteCourse 1010
exec sp_SelectTrackCourses 1



--- Track Table 
--- return	1  Sucess
--- return -1 no course with crs_id
--- return -2 no instructor with ins_id

GO
create or alter proc sp_CreateTrack(
				@track_name varchar(100))
as
begin
	insert into track (track_name) 
				values (@track_name)
	return 1
end

GO
create or alter proc sp_UpdateTrack(
				@track_id int,
				@track_name varchar(100))
as
begin
	if not exists (select 1 from track 
					     where track_id=@track_id)
		return -1
	update track 
		set track_name = ISNULL(@track_name,track_name)
		where track_id=@track_id
	return 1
end

GO
create or alter proc sp_DeleteTrack(
				@track_id int)
as
begin
	if not exists (select 1 from track 
					     where track_id=@track_id)
		return -1
	delete from track
			where track_id=@track_id
	return 1
end
GO
create or alter proc sp_SelectTrack(
				@track_id int)
as
begin
	if not exists (select 1 from track 
					     where track_id=@track_id)
		return -1
	select * from track
			where track_id=@track_id
	return 1
end




exec sp_CreateTrack 'CreateTrack'
exec sp_SelectTrack 1
exec sp_UpdateTrack 11,'track'
exec sp_DeleteTrack 11



--- Topic
--- return	1  Sucess
--- return -1 no topic with topic_id
GO
create or alter proc sp_CreateTopic(
				@topic_name varchar(100))
as
begin
	insert into topic (topic_name) 
				values (@topic_name)
	return 1
end

GO
create or alter proc sp_UpdateTopic(
				@topic_id int,
				@topic_name varchar(100))
as
begin
	if not exists (select 1 from topic 
					     where topic_id=@topic_id)
		return -1
	update topic 
		set topic_name = ISNULL(@topic_name,topic_name)
		where topic_id=@topic_id
	return 1
end

GO
create or alter proc sp_DeleteTopic(
				@topic_id int)
as
begin
	if not exists (select 1 from topic 
					     where topic_id=@topic_id)
		return -1
	delete from topic
			where topic_id=@topic_id
	return 1
end
GO
create or alter proc sp_SelectTopic(
				@topic_id int)
as
begin
	if not exists (select 1 from topic 
					     where topic_id=@topic_id)
		return -1
	select * from topic
			where topic_id=@topic_id
	return 1
end

---crs_topic
--- return  1 Success
--- return -1 No course with crs_id
--- return -2 No topic with topic_id
--- return -3 Topic already assigned to course

GO
create or alter proc sp_AddTopicToCourse(
				@crs_id int,
				@topic_id int)
as
begin
	if not exists (select 1 from course 
					     where crs_id=@crs_id)
		return -1
	if not exists (select 1 from topic 
					     where topic_id=@topic_id)
		return -2
	if exists (select 1 from crs_topic 
					where crs_id=@crs_id 
					and topic_id=@topic_id)
		return -3
	insert into crs_topic(crs_id,topic_id)
			values(@crs_id,@topic_id)
	return 1
end


GO
create or alter proc sp_DeleteTopicFromCourse(
				@crs_id int,
				@topic_id int)
as
begin 
	if not exists (select 1 from crs_topic 
					where crs_id=@crs_id 
					and topic_id=@topic_id)
		return -3
	delete from crs_topic
		where crs_id=@crs_id and topic_id=@topic_id
	return 1
end

GO
create or alter proc sp_SelectCourseTopics(
				@crs_id int
				)
as
begin
	if not exists (select 1 from course 
					     where crs_id=@crs_id)
		return -1
	select t.topic_id,t.topic_name 
		from crs_topic ct join topic t
		on ct.topic_id=t.topic_id
		where crs_id=@crs_id
	return 1
end


--- return -1 no instructor with this id
--- return  1 Success
GO
create or alter proc sp_SelectInstructorCoursesAndNumOfStudent(
				@ins_id int)
as
begin
	if not exists (select 1 from instructor ins 
						join user_account u
						on ins.user_id=u.user_id
						where ins.user_id=@ins_id and is_active=1)
		return -1
	select crs_name,COUNT(s.user_id) as NumOfStudent
	from course c join track t on c.track_id=t.track_id
	join student s on s.track_id=t.track_id
	where c.ins_id=1
	group by crs_name
	return 1
end
GO

exec sp_SelectInstructorCoursesAndNumOfStudent 1

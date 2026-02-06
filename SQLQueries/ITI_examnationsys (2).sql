create database ITIExaminationSystem2

use ITIExaminationSystem2

-- 1- track table

create table track (
    track_id int primary key identity,
    track_name varchar(100) not null
);
-- 1 User Account

create table user_account
(
    user_id int primary key identity,
    user_name varchar(50) ,
    pass varchar(200),
    role tinyint CHECK (role in (0,1,2)), --(role in ('student','instructor','admin')),
    is_active bit default(1)
)

ALTER TABLE user_account
ADD CONSTRAINT UQ_user_name UNIQUE (user_name);
-- 3 student 

create table student (
    user_id int primary key,
    std_phoneno varchar(20),
    std_first_name varchar(50) not null,
    std_last_name varchar(50) not null,
    std_email varchar(100) unique,
    std_city varchar(50),
    std_street varchar(100),
    std_zipcode varchar(10),
    std_gender char(1) check (std_gender in ('M','F')),
    std_age int check (std_age > 0),
    track_id int NOT NULL,
    foreign key( user_id ) 
	references user_account(user_id) 
	ON DELETE CASCADE,
    foreign key (track_id) 
	references track(track_id) 
	ON DELETE CASCADE ON UPDATE CASCADE
);

select * from student

-- 4 instructor table 

create table instructor (
    user_id int primary key,
    ins_name varchar(100) not null,
    ins_gender char(1) check (ins_gender in ('M','F')),
    ins_phoneNo varchar(20),
    ins_email varchar(100) unique,
    ins_salary decimal(10,2) CHECK (ins_salary BETWEEN 3000 AND 15000),
    ins_dob date,
    ins_city varchar(50),
    ins_street varchar(100),
    FOREIGN KEY (user_id)
        REFERENCES user_account(user_id)
        ON DELETE CASCADE
);


-- 5- Course Table 
create table course (
    crs_id int primary key identity(1000,1),
    crs_name varchar(100) not null,
    track_id int not null,
	ins_id int,
    foreign key (track_id) references Track(track_id)  
	ON DELETE CASCADE ON UPDATE CASCADE,
    foreign key (ins_id) references instructor(user_id)  
	ON DELETE SET NULL ON UPDATE CASCADE
);


-- 6- Topic 
create table topic (
    topic_id int primary key identity(4000,1),
    topic_name varchar(100) not null
);

-- 7- crs-Topic 
create table crs_topic (
    crs_id int,
    topic_id int,
    primary key (crs_id, topic_id),
    foreign key (crs_id) references course(crs_id) 
	ON DELETE CASCADE ON UPDATE CASCADE,
    foreign key (topic_id) references topic(topic_id) 
	ON DELETE CASCADE ON UPDATE CASCADE
);

-- 8 - Exam 

create table exam (
    ex_no int primary key identity(1,1),
    ex_duration int not null,
    ex_date date not null ,
    crs_id int not null,
    foreign key (crs_id) references course(crs_id) 
	ON DELETE CASCADE ON UPDATE CASCADE
);

-- 9 - Question 
create table question (
    qus_no int primary key identity(1,1),
    qus_text varchar(500) not null,
    qus_type bit not null,
    correct_answer varchar(200) not null 
);

--- 10 - course_question
CREATE TABLE course_question (
    crs_id int,
    qus_no int,
    PRIMARY KEY (Crs_id, qus_no),
    FOREIGN KEY (Crs_id) REFERENCES course(Crs_id) 
	ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (qus_no) REFERENCES question(qus_no)
	ON DELETE CASCADE ON UPDATE CASCADE
);


-- 11 exam_question
create table exam_question (
    ex_no int,
    qus_no int,
    primary key (ex_no, qus_no),
    foreign key (ex_no) references exam(ex_no) ON DELETE CASCADE ON UPDATE CASCADE,
    foreign key (qus_no) references question(qus_no) ON DELETE CASCADE ON UPDATE CASCADE
);



-- 12  Choice
create table choice (
    choice_id int primary key identity(1,1),
    qus_no int,
    choice_text varchar(200),
    foreign key (qus_no) references question(qus_no) ON DELETE CASCADE ON UPDATE CASCADE
);


-- 13 
create table student_exam_grade (
    ex_no int,
    std_id int,
    grade decimal(5,2) check (grade between 0 and 100), -- here's to check if not neg. numbers + wth range 0-100 wth 2 decimals
    primary key (ex_no, std_id),
    foreign key (ex_no) references exam(ex_no)
	ON DELETE NO ACTION ON UPDATE NO ACTION,
    foreign key (std_id) references student(user_id) 
	ON DELETE CASCADE ON UPDATE CASCADE
);


-- 14 Student_Exam_Ans
create table student_exam_ans (
    ex_no int not null,
    std_id int not null,
    qus_no int not null,
    choice_id int,
    primary key(ex_no,std_id,qus_no) ,
    foreign key (ex_no) references exam(ex_no) 
	ON DELETE NO ACTION ON UPDATE NO ACTION,
    foreign key (std_id) references student(user_id) 
	ON DELETE CASCADE ON UPDATE CASCADE,
    foreign key (qus_no) references question(qus_no) 
	ON DELETE NO ACTION ON UPDATE NO ACTION,
    foreign key (choice_id) references choice(choice_id) 
	ON DELETE NO ACTION ON UPDATE NO ACTION
);


BACKUP DATABASE ITIExaminationSystem
TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup\DB_Project.bak'
WITH FORMAT;


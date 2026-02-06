use ITIExaminationSystem2
-- return  1 : success
-- return -1 : student not found
-- return -2 : exam not found
-- return     -31 : record already exists
--             -32 : record not found

----------------------------------student_exam_grade--------------------------------------------------------
                      --    [Update || insert || Delete ||select ]
					  select * from student_exam_grade
--=========================================================================================================
--------------------------------------INSERT---------------------------------------------------------------
GO
CREATE OR ALTER PROC sp_CreateStudentExamGrade
(
    @ex_no INT,
    @std_id INT,
    @grade DECIMAL(5,2)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM student WHERE user_id = @std_id)
        RETURN -1

    IF NOT EXISTS (SELECT 1 FROM exam WHERE ex_no = @ex_no)
        RETURN -2

    IF EXISTS (
        SELECT 1 FROM student_exam_grade
        WHERE ex_no = @ex_no AND std_id = @std_id
    )
         RETURN -31

    INSERT INTO student_exam_grade (ex_no, std_id, grade)
    VALUES (@ex_no, @std_id, @grade)

    RETURN 1
END
GO

DECLARE @result INT

EXEC @result = sp_CreateStudentExamGrade
    @ex_no = 1,
    @std_id = 1,
    @grade = 95

SELECT @result AS ResultCode

 --===========================================================================================================
 -----------------------------------------Update--------------------------------------------------------------
GO
CREATE OR ALTER PROC sp_UpdateStudentExamGrade
(
    @ex_no INT,
    @std_id INT,
    @grade DECIMAL(5,2) = NULL
)
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM student_exam_grade
        WHERE ex_no = @ex_no AND std_id = @std_id
    )
          RETURN -32

    UPDATE student_exam_grade
    SET grade = ISNULL(@grade, grade)
    WHERE ex_no = @ex_no AND std_id = @std_id

    RETURN 1
END
GO
DECLARE @result INT

EXEC @result = sp_UpdateStudentExamGrade
    @ex_no = 1,
    @std_id = 1,
    @grade = 88

SELECT @result AS ResultCode
GO

 --===================================================================================================================
 ----------------------------------------------------Delete---------------------------------------------
CREATE OR ALTER PROC sp_DeleteStudentExamGrade
(
    @ex_no INT,
    @std_id INT
)
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM student_exam_grade
        WHERE ex_no = @ex_no AND std_id = @std_id
    )
        RETURN -32

    DELETE FROM student_exam_grade
    WHERE ex_no = @ex_no AND std_id = @std_id

    RETURN 1
END
GO
EXEC  sp_DeleteStudentExamGrade 9,8
--==========================================================================================================
 ----------------------------------------SelectCoursesForStudent-------------------------------------------
GO
CREATE OR ALTER PROC sp_SelectStudentExamGrade
(
    @ex_no INT,
    @std_id INT
)
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM student_exam_grade
        WHERE ex_no = @ex_no AND std_id = @std_id
    )
        RETURN -32

    SELECT *
    FROM student_exam_grade
    WHERE ex_no = @ex_no AND std_id = @std_id

    RETURN 1
END
GO

DECLARE @I INT
EXEC @I=sp_SelectStudentExamGrade 9,9
SELECT @I 
 --=========================================================================================================
-----------------------------------SelectStudentsInCourse--------------------------------------------------

GO
CREATE OR ALTER PROC sp_SelectExamGrades
(
    @ex_no INT
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM exam WHERE ex_no = @ex_no)
        RETURN -2

    SELECT
        s.user_id,
        s.std_first_name + ' ' + s.std_last_name AS FullName,
        g.grade
    FROM student_exam_grade g
    INNER JOIN student s ON g.std_id = s.user_id
    WHERE g.ex_no = @ex_no

    RETURN 1
END
GO
DECLARE @I INT
EXEC @I=sp_SelectExamGrades  9
SELECT @I 



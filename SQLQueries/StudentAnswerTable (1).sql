--return 1 sucess 
--return -1 no student found 
--return -2 no exam number found
--return -3 no question with student found 
----------------------------------sstudent_exam_ans--------------------------------------------------------
use ITIExaminationSystem2

GO
                      --    
--=========================================================================================================
--------------------------------------Insert---------------------------------------------------------------
CREATE or alter PROC sp_createStudentExamAnswer
(
    @ex_no INT,
    @std_id INT,
    @qus_no INT,
    @choice_id INT
)
AS
BEGIN
    -- check student existence 
    IF NOT EXISTS (SELECT 1 FROM student WHERE user_id = @std_id)
        RETURN -1

    -- check question exists
    IF NOT EXISTS (SELECT 1 FROM question WHERE qus_no = @qus_no)
        RETURN -3

    INSERT INTO student_exam_ans
        (ex_no, std_id, qus_no, choice_id)
    VALUES
        (@ex_no, @std_id, @qus_no, @choice_id)

    RETURN 1
END
GO
DECLARE @result INT
 
EXEC @result = sp_createStudentExamAnswer
    @ex_no = 20,
    @std_id = 11,
    @qus_no = 1,
    @choice_id = 2;
	SELECT @result AS Result;

GO
--==========================================================================================================
---------------------------------------------UPDATE---------------------------------------------------------
CREATE OR ALTER PROC sp_UpdateStudentExamAns
(
    @ex_no INT,
    @std_id INT = NULL,
    @qus_no INT = NULL,
    @choice_id INT = NULL
)
AS
BEGIN
    -- check record exists
    IF NOT EXISTS (SELECT 1 FROM student_exam_ans WHERE ex_no = @ex_no)
        RETURN -1

    -- check student if provided
    IF @std_id IS NOT NULL
       AND NOT EXISTS (SELECT 1 FROM student WHERE user_id = @std_id)
        RETURN -2

    -- check question if provided
    IF @qus_no IS NOT NULL
       AND NOT EXISTS (SELECT 1 FROM question WHERE qus_no = @qus_no)
        RETURN -3

    UPDATE student_exam_ans
    SET
        std_id      = ISNULL(@std_id, std_id),
        qus_no      = ISNULL(@qus_no, qus_no),
        choice_id   = ISNULL(@choice_id, choice_id)
    WHERE ex_no = @ex_no

    RETURN 1
END
GO

EXEC sp_UpdateStudentExamAns
    @ex_no = 10
GO

---
DECLARE @RES INT
EXEC @RES=sp_UpdateStudentExamAns
    @ex_no = 10,
    @std_id = 999;
	select @RES as result
	--------------
EXEC @RES= sp_UpdateStudentExamAns
    @ex_no = 20,
    @std_id = 2,
    @choice_id = 5;
GO
--============================================================================================================
----------------------------------------------DELETE------------------------------------------------------------------------------
CREATE  or alter PROC sp_DeleteStudentExamAns
(
    @ex_no INT
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM student_exam_ans WHERE ex_no = @ex_no)
        RETURN -2

    DELETE FROM student_exam_ans
    WHERE ex_no = @ex_no

    RETURN 1
END
GO
EXEC sp_DeleteStudentExamAns
    @ex_no = 10;

GO

--========================================================================================================
--------------------------------------------SELECT (By ex_no)  -----------------------------------------------------
CREATE or alter PROC sp_SelectStudentExamAns
(
    @ex_no INT
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM student_exam_ans WHERE ex_no = @ex_no)
        RETURN -2

    SELECT *
    FROM student_exam_ans
    WHERE ex_no = @ex_no

    RETURN 1
END
GO
DECLARE @result INT

EXEC @result = sp_SelectStudentExamAns
    @ex_no = 1000
	select @result
--===========================================================================================================
------------------------------------SELECT by Studen---------------------------------------------------------
GO

CREATE or alter  PROC sp_SelectStudentExamAnswers
(
    @std_id INT
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM student WHERE user_id = @std_id)
        RETURN -1

    SELECT ex_no, qus_no
    FROM student_exam_ans
    WHERE std_id = @std_id

    RETURN 1
END
GO
EXEC  sp_SelectStudentExamAnswers
    @std_id = 1;
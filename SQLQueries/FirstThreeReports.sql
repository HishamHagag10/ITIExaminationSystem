USE ITIExaminationSystem2
GO
--FIRST REPORT
--Report that returns the students information according to Department No parameter.
--With sp that takes Track ID
-- SETTING FOR POWER BI

--EXEC sp_addlinkedserver 
--    @server     = N'LOOPBACK',
--    @srvproduct = N'',
--    @provider   = N'MSOLEDBSQL',         
--    @datasrc    = @@SERVERNAME;  
GO
--EXEC sp_serveroption 'LOOPBACK', 'data access', TRUE;

GO
--SELECT * FROM OPENQUERY(LOOPBACK, 'EXEC ITIExaminationSystem2.dbo.sp_ReportStudentsByTrack @trackId = 2')

GO
CREATE OR ALTER PROC sp_ReportStudentsByTrack 
    @trackId INT = NULL  
AS
BEGIN
    SELECT 
        s.user_id, 
        s.std_first_name, 
        s.std_last_name, 
        u.user_name, 
        s.std_email,
        s.track_id   -- Add this if not already, for slicing
    FROM student s
    INNER JOIN user_account u ON s.user_id = u.user_id
    WHERE @trackId IS NULL OR s.track_id = @trackId;
END

GO

exec sp_ReportStudentsByTrack 2

GO

---------------------------------------------------------------
--SECOND REPORT:
--Report that takes the student ID and returns the grades of the student in all courses. %
--Did it two times
--First Time: with sp taking std_id
GO

CREATE OR ALTER PROC sp_Report_Student_Grades
    @stid INT
AS
BEGIN
    SET NOCOUNT ON;

    WITH LatestExamPerCourse AS (
        SELECT 
            sg.std_id,
            e.crs_id,
            MAX(e.ex_date) AS LatestExamDate,
            MAX(sg.grade) AS LatestGrade   -- or AVG, SUM, etc. — choose your business logic
        FROM student_exam_grade sg
        INNER JOIN exam e ON e.ex_no = sg.ex_no
        WHERE sg.std_id = @stid
        GROUP BY sg.std_id, e.crs_id
    )
    SELECT 
        c.crs_name AS CourseName,
        CONCAT(CAST(l.LatestGrade AS DECIMAL(5,0)), '%') AS Grade,
        COUNT(*) OVER (PARTITION BY c.crs_name) AS ExamsInCourse,   -- optional
        l.LatestExamDate
    FROM LatestExamPerCourse l
    INNER JOIN course c ON c.crs_id = l.crs_id
    ORDER BY c.crs_name;
END
GO
EXEC sp_Report_Student_Grades  4

GO

--------------------------------------------------------------------
--SECOND REPORT:
--Did it two times
--First Time: with FInction taking std Full Name
CREATE or ALTER FUNCTION dbo.fn_Report_Student_Grades
(
    @stdName NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    WITH LatestExamPerCourse AS (
        SELECT
            sg.std_id,
            e.crs_id,
            MAX(e.ex_date) AS LatestExamDate,
            MAX(sg.grade) AS LatestGrade
        FROM student_exam_grade sg
        INNER JOIN exam e ON e.ex_no = sg.ex_no
        INNER JOIN student s ON s.user_id = sg.std_id
        WHERE s.std_first_name + ' ' + s.std_last_name = @stdName
        GROUP BY sg.std_id, e.crs_id
    )
    SELECT
        c.crs_name AS CourseName,
        CONCAT(CAST(l.LatestGrade AS DECIMAL(5,0)), '%') AS Grade,
        COUNT(*) OVER (PARTITION BY c.crs_name) AS ExamsInCourse,
        l.LatestExamDate
    FROM LatestExamPerCourse l
    INNER JOIN course c ON c.crs_id = l.crs_id
    -- NO ORDER BY here — move sorting to Power BI report visual
);
GO

select * from fn_Report_Student_Grades('Ahmed Ali')

GO

----------------------------------------------------------------------
--Third REPORT:
--using function taking ins_name
--Report that takes the instructor ID and returns the 
--name of the courses that he teaches and the number of student per course.
CREATE OR ALTER FUNCTION dbo.fn_InstructorCoursesWithStudentCount
(
    @ins_name NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT
        c.crs_id,
        c.crs_name          AS CourseName,
        COUNT(DISTINCT s.user_id) AS NumberOfStudentsInCourse,   -- ← this is the correct count
        t.track_name        AS TrackName,
        i.ins_name          AS InstructorName
    FROM instructor i
    INNER JOIN course c
        ON c.ins_id = i.user_id
    INNER JOIN track t
        ON t.track_id = c.track_id
    INNER JOIN student s               -- ← join to students via track
        ON s.track_id = c.track_id
    WHERE i.ins_name = @ins_name
      AND i.ins_name IS NOT NULL
    GROUP BY
        c.crs_id,
        c.crs_name,
        t.track_name,
        i.ins_name
);
GO

select * from fn_InstructorCoursesWithStudentCount('DR Hassan')

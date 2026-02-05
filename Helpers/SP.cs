using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.Helpers
{
    public static class SP
    {
        public const string Login = "sp_login";
        public const string AddStudent = "sp_CreateStudent";
        public const string DeleteStudent = "sp_deleteStudent";
        public const string UpdateStudent = "sp_UpdateStudent";
        public const string SelectStudents = "sp_SelectStudents";
        public const string SelectStudent = "sp_SelectStudent";
        
        public const string AddInstructor = "sp_CreateInstructor";
        public const string DeleteInstructor = "sp_deleteInstructor";
        public const string UpdateInstructor = "sp_UpdateInstructor";
        public const string SelectInstructors = "sp_SelectInstructors";
        public const string SelectInstructor = "sp_SelectInstructor";

        public const string AddCourse = "sp_CreateCourse";
        public const string DeleteCourse = "sp_DeleteCourse";
        public const string UpdateCourse = "sp_UpdateCourse";
        public const string SelectCourses = "sp_SelectCourses";
        public const string SelectCourse = "sp_SelectCourse";
        public const string getstudentbyid = "sp_SelectStudent";
        public const string getstudentCourse = "sp_SelectCoursesForStudent";
        public const string takeExam= "sp_TakeExam";
        public const string correctExam = "sp_examcorrection";
        //INSTRUCTOR
        public const string GetInstructorById = "sp_selectInstructor";
        //VIEWCOURSES
        public const string InstructorCourses = "sp_Selectinstructorwithcourses";
        //
        public const string ExamGeneration = "sp_examGeneration";

        public const string AddTrack = "sp_CreateTrack";
        public const string DeleteTrack = "sp_DeleteTrack";
        public const string UpdateTrack = "sp_UpdateTrack";
        public const string SelectTracks = "sp_SelectTracks";
        public const string SelectTrack = "sp_SelectTrack";
        public const string AddStudentAnswer = "sp_createStudentExamAnswer";
        public const string studentExamAns = "sp_SelectStudentExamAnswers";

        public const string GetCourseExams = "sp_getCourseExams";
        public const string GetExamGrades = "sp_SelectExamGrades";
        public const string SelectStudentExamGrade = "sp_SelectStudentExamGrade";
    }

}

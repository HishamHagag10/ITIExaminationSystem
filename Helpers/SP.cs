using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.Helpers
{
    public static class SP
    {
        public const string Login = "login_Sp";
        public const string AddStudent = "insertStudent";
        public const string DeleteStudent = "deleteStudent";
        public const string UpdateStudent = "sp_UpdateStudent";
        public const string SelectStudents = "sp_SelectStudents";
        public const string SelectStudent = "selectStudent";
        
        public const string AddInstructor = "insertInstructor";
        public const string DeleteInstructor = "deleteInstructor";
        public const string UpdateInstructor = "sp_UpdateInstructor";
        public const string SelectInstructors = "sp_SelectInstructors";
        public const string SelectInstructor = "selectInstructor";

        public const string AddCourse = "sp_CreateCourse";
        public const string DeleteCourse = "sp_DeleteCourse";
        public const string UpdateCourse = "sp_UpdateCourse";
        public const string SelectCourses = "sp_SelectCourses";
        public const string SelectCourse = "sp_SelectCourse";
        public const string getstudentbyid = "selectStudent";
        public const string getstudentCourse = "sp_SelectCoursesForStudent";
        public const string takeExam= "TakeExam";
        public const string correctExam = "sp_examcorrection";
        //INSTRUCTOR
        public const string GetInstructorById = "selectInstructor";
        //VIEWCOURSES
        public const string InstructorCourses = "selectinstructorwithcourses";
        //
        public const string ExamGeneration = "sp_examGeneration";

        public const string AddTrack = "sp_CreateTrack";
        public const string DeleteTrack = "sp_DeleteTrack";
        public const string UpdateTrack = "sp_UpdateTrack";
        public const string SelectTracks = "sp_SelectTracks";
        public const string SelectTrack = "sp_SelectTrack";
        public const string AddStudentAnswer = "so_createStudentExamAnswer";
        public const string studentExamAns= "sp_SelectStudentExamAnswers";
    }

}

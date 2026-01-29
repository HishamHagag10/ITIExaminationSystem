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
        public const string getstudentbyid = "selectStudent";
        public const string getstudentCourse = "sp_SelectCoursesForStudent";
        public const string takeExam= "TakeExam";
        public const string correctExam = "sp_examcorrection";
        //INSTRUCTOR
        public const string GetInstructorById = "selectInstructor";
        //VIEWCOURSES
        public const string InstructorCourses = "selectinstructorwithcourses";
        //

         


    }

}

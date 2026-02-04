using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{
    public class ExamGradeDto:DTO
    {
        public int ex_no { get; set; }
        public int std_id { get; set; }
        public int grade { get; set; }
    }
}

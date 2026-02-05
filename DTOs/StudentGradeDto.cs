using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{
    internal class StudentGradeDto:DTO
    {
        public int std_id { get; set; }
        public decimal Grade { get; set; }  // percentage 0-100
    }
}

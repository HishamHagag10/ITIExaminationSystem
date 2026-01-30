using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{
    
        public class ins_StudentGradeDto:DTO
        {
            public int StudentId { get; set; }
            public string FullName { get; set; }
            public decimal Grade { get; set; }
        }

    
}

using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{
 
        public class ExamDto : DTO
        {
            public int ExamId { get; set; }
            public string ExamName { get; set; }
            public DateTime ExamDate { get; set; }
            public int TotalMarks { get; set; }
        

    }
}

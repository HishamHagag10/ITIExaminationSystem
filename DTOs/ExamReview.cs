using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{

public class ExamReview: DTO
    {
        public int qus_no { get; set; }
        public string qus_text { get; set; }
        public string student_answer { get; set; }
        public string correct_answer { get; set; }
        public string result { get; set; }
    }

}


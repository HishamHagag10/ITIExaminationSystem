using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{
   
        public class Question:DTO
        {
  
            public int qus_no { get; set; }
        public int ex_no { get; set; }
        public string qus_text { get; set; }

            public string qus_type { get; set; } 
            public string correct_answer { get; set; }
            public string choices { get; set; } // 
            public List<string> Choices { get; set; } = new List<string>(); 
            public string SelectedAnswer { get; set; } 
        }

    }


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

            public bool qus_type { get; set; } 
            public string correct_answer { get; set; }
            public string choices { get; set; } // 
            public string choicesId { get; set; } //
            public List<Choice> Choices { get; set; } = new List<Choice>(); 
            public string SelectedAnswer { get; set; } 
        }
        public class Choice{
            public int ChoiceId { get; set; }
            public string ChoiceText { get; set; }

        }
}


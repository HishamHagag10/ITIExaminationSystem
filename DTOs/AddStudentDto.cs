using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{
    public class AddStudentDto:DTO
    {
        public string user_name { get; set; } = string.Empty;
        public string pass { get; set; } = string.Empty;
        public string std_first_name { get; set; } = string.Empty;
        public string std_last_name { get; set; } = string.Empty;
        public string std_phoneno { get; set; } = string.Empty;
        public string std_email { get; set; } = string.Empty;
        public string std_city { get; set; } = string.Empty;
        public string std_street { get; set; } = string.Empty;
        public char std_gender { get; set; } 
        public int std_age { get; set; }
        public string std_zipcode { get; set; } = string.Empty;
        public int track_id { get; set; }
    }
}

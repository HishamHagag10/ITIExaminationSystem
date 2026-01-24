using DB_Project.DTOs;
using System;

namespace ITIExaminationSystem.DTOs
{
    public class SelectInstructorDetailDto : DTO
    {
        public int ins_id { get; set; }
        public string user_name { get; set; } = string.Empty;
        public string pass { get; set; } = string.Empty;
        public string ins_name { get; set; } = string.Empty;
        public char ins_gender { get; set; }
        public string ins_phoneno { get; set; } = string.Empty;
        public string ins_email { get; set; } = string.Empty;
        public decimal ins_salary { get; set; }
        public DateTime ins_dob { get; set; }
        public string ins_city { get; set; } = string.Empty;
        public string ins_street { get; set; } = string.Empty;
    }
}

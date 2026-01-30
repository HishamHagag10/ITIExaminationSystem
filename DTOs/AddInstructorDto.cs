using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{
    public class AddInstructorDto : DTO
    {
        public string user_name { get; set; }
        public string pass { get; set; }
        public string ins_name { get; set; }
        public char? ins_gender { get; set; }
        public string ins_phoneNo { get; set; }
        public string ins_email { get; set; }
        public decimal ins_salary { get; set; }
        public DateTime ins_dob { get; set; }
        public string ins_city { get; set; }
        public string ins_street { get; set; }
    }

}

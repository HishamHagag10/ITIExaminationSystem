using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{
    public  class InstructorDTO:DTO
    {
      
            public int Ins_Id { get; set; }
            public string Ins_Name { get; set; }
            public string Ins_Gender { get; set; }
            public string Ins_Email { get; set; }
            public string Ins_PhoneNo { get; set; }
            public decimal Ins_Salary { get; set; }
            public DateTime Ins_Dob { get; set; }
            public string Ins_City { get; set; }
            public string Ins_Street { get; set; }
            public string User_Name { get; set; }
            public string Pass { get; set; }
        }


    }

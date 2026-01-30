using System;
using System.Collections.Generic;
using System.Text;
using DB_Project.DTOs;
namespace DB_Project.DTOs
{
    internal class StudentDTO : DTO
    {
      
            public string std_first_name { get; set; }
            public string std_last_name { get; set; }
            public string std_phoneno { get; set; }
            public string std_email { get; set; }

           
            public string FirstName => std_first_name;
            public string LastName => std_last_name;
            public string Phone => std_phoneno;
            public string Email => std_email;
        }

    }


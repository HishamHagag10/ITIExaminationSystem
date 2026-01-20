using System;
using System.Collections.Generic;
using System.Text;

namespace DB_Project.DTOs
{
    public class DTO
    {
    }
    public class LogedUser : DTO
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public override string ToString()
        {
            return Id+" "+Role;
        }
    }
}

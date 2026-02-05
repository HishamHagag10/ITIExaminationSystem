using DB_Project.Helpers;
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
        public int Id { get; set; }
        public Role Role { get; set; }
        public override string ToString()
        {
            return Id+" "+Role;
        }
    }
}

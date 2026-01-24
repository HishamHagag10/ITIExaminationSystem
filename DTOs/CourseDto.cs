using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{
    public class CourseDto : DTO
    {
        public string crs_name { get; set; }
        public int? ins_id { get; set; }
        public int track_id { get; set; }
    }
}

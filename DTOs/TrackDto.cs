using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{
    public class TrackDto : DTO
    {
        public int track_id { get; set; }
        public string track_name { get; set; } = string.Empty;
    }
}

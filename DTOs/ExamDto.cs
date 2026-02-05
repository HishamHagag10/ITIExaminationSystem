using DB_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem.DTOs
{
 
        public class ExamDto : DTO
        {
            public int ex_no { get; set; }
            public int crs_id { get; set; }
            public DateTime ex_date { get; set; }
            public int ex_duration { get; set; }
        

    }
}

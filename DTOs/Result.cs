using System;
using System.Collections.Generic;
using System.Text;

namespace DB_Project.DTOs
{
    public class Result<T>
    {
        public int Status { get; set; }
        public T? Data { get; set; }
        public Result(T? data, int status)
        {
            Data = data;
            Status = status;
        }
    }
}

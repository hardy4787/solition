using System;

namespace ApiCallProject.Models
{
    public class ApiCallInfo
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public DateTime CreatedDate { get; set; }
        public double TimeTaken { get; set; }
    }
}

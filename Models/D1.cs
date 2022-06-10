using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D1
    {
        public int Id { get; set; }
        public int RefFunctionId { get; set; }
        public string D1_EmployeeId { get; set; }
        public string D1_EmployeeName { get; set; }
        public string D1_Email { get; set; }
        public string D1_PhoneNo { get; set; }
        public DateTime? D1_DateStart { get; set; }

        public Guid ReportHeaderId { get; set; }
        public virtual ReportHeader ReportHeader { get; set; }
        public virtual RefFunction RefFunction { get; set; }
    }
}

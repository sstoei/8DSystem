using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D7_B
    {
        public int Id { get; set; }
        public string Process { get; set; }
        public string Responsible { get; set; }
        public DateTime? PlanValidationDate { get; set; }
      


        public int D7Id { get; set; }
        public virtual D7 D7 { get; set; }
    }
}

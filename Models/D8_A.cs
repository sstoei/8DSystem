using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D8_A
    {
        public int Id { get; set; }
        public DateTime? PlanDate { get; set; }
        public DateTime? ActualDate { get; set; }

        public int D8Id { get; set; }
        public virtual D8 D8 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D7_A
    {
        public int Id { get; set; }
        public string PreventiveAction { get; set; }
        public string PAImplementationPlan { get; set; }
        [StringLength(7)]
        public string TeamMemberId { get; set; }
        public string TeamMemberName { get; set; }
        public string TeamMemberEmail { get; set; }
        public DateTime? TargetDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? RefPCAStatusId { get; set; }
        public virtual RefPCAStatus RefPCAStatus { get; set; }


        public int D7Id { get; set; }
        public virtual D7 D7 { get; set; }
    }
}

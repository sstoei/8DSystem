using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D6_Action
    {
        public int Id { get; set; }       
        public string Detail { get; set; }
        public string ImplementationPlan { get; set; }
        public string TeamMemberId { get; set; }
        public string TeamMemberName { get; set; }
        public string TeamMemberEmail { get; set; }
        public bool? CustomerConcurrence { get; set; }
        public DateTime? ImplementActionDate { get; set; }
        public string VerificationMethod { get; set; }
        public int? RefPCAStatusId { get; set; }
        public virtual RefPCAStatus RefPCAStatus { get; set; }
        public int D6Id { get; set; }
        public virtual D6 D6 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D5_Action
    {
        public int Id { get; set; }
        public int? RefCauseSourceId { get; set; }
        public string Detail { get; set; }
        public bool? Verify { get; set; }
        public DateTime? Date { get; set; }
        public string VerificationMethod { get; set; }
        public int D5Id { get; set; }
        public virtual D5 D5 { get; set; }
        public virtual RefCauseSource RefCauseSource { get; set; }

    }
}

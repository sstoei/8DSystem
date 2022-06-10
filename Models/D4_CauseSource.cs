using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D4_CauseSource
    {
        public int Id { get; set; }
        public int? RefCauseSourceId { get; set; }
        public string CauseDescription { get; set; }
        public bool? Verified { get; set; }
        public DateTime? Date { get; set; }
        public string VerificationMethod { get; set; }


        public virtual RefCauseSource RefCauseSource { get; set; }

        public int D4Id { get; set; }
        public virtual D4 D4 { get; set; }
    }   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D4
    {
        public D4()
        {
            D4_Attachments = new HashSet<D4_Attachment>();          
            D4_CauseSources = new HashSet<D4_CauseSource>();
        }
        public int Id { get; set; }
        public bool? D4_HasEscapePointCausesBeenAddressed { get; set; }
        public bool? D4_CanCausesExplainDifferences { get; set; }
        public bool? D4_IdentifyCausesInProcessFMEA { get; set; }

        public bool? D4_FishBone { get; set; }
        public string FishBone_Main { get; set; }
        public string FishBone_Machine { get; set; }
        public string FishBone_Manufacturing { get; set; }
        public string FishBone_Measurement { get; set; }
        public string FishBone_Material { get; set; }
        public string FishBone_Environment { get; set; }

        public bool? D4_FiveWhy { get; set; }
        public string DefineTheProblem { get; set; }
        public string Why1 { get; set; }
        public string How1 { get; set; }
        public string Why2 { get; set; }
        public string How2 { get; set; }
        public string Why3 { get; set; }
        public string How3 { get; set; }
        public string Why4 { get; set; }
        public string How4 { get; set; }

        public Guid ReportHeaderId { get; set; }
        public virtual ReportHeader ReportHeader { get; set; }       
        public virtual ICollection<D4_Attachment> D4_Attachments { get; set; }        
        public virtual ICollection<D4_CauseSource> D4_CauseSources { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D7
    {
        public D7()
        {
            D7_Attachments = new HashSet<D7_Attachment>();
            D7_As = new HashSet<D7_A>();
            D7_Bs = new HashSet<D7_B>();
            D7_Cs = new HashSet<D7_C>();
        }
        public int Id { get; set; }
        public string Detail { get; set; }
        public Guid ReportHeaderId { get; set; }
        public virtual ReportHeader ReportHeader { get; set; }
        public virtual ICollection<D7_Attachment> D7_Attachments { get; set; }
        public virtual ICollection<D7_A> D7_As { get; set; }
        public virtual ICollection<D7_B> D7_Bs { get; set; }
        public virtual ICollection<D7_C> D7_Cs { get; set; }
    }
}

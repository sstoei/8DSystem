using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D8
    {
        public D8()
        {
            D8_Attachments = new HashSet<D8_Attachment>();
            D8_As = new HashSet<D8_A>();
            D8_Bs = new HashSet<D8_B>();
            D8_Cs = new HashSet<D8_C>();
        }
        public int Id { get; set; }
        public string Detail { get; set; }
        public Guid ReportHeaderId { get; set; }
        public virtual ReportHeader ReportHeader { get; set; }
        public virtual ICollection<D8_Attachment> D8_Attachments { get; set; }
        public virtual ICollection<D8_A> D8_As { get; set; }
        public virtual ICollection<D8_B> D8_Bs { get; set; }
        public virtual ICollection<D8_C> D8_Cs { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D6
    {
        public D6()
        {
            D6_Attachments = new HashSet<D6_Attachment>();
            D6_Actions = new HashSet<D6_Action>();
        }
        public int Id { get; set; }
        public string Detail { get; set; }
        public Guid ReportHeaderId { get; set; }
        public virtual ReportHeader ReportHeader { get; set; }
        public virtual ICollection<D6_Attachment> D6_Attachments { get; set; }
        public virtual ICollection<D6_Action> D6_Actions { get; set; }
    }
}

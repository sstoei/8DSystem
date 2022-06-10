using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D5
    {
        public D5()
        {
            D5_Attachments = new HashSet<D5_Attachment>();
            D5_Actions = new HashSet<D5_Action>();
        }
        public int Id { get; set; }
        public string Detail { get; set; }
        public Guid ReportHeaderId { get; set; }
        public virtual ReportHeader ReportHeader { get; set; }


        public virtual ICollection<D5_Attachment> D5_Attachments { get; set; }
        public virtual ICollection<D5_Action> D5_Actions { get; set; }
    }
}

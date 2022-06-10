using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D3
    {
        public D3()
        {
            D3_Actions = new HashSet<D3_Action>();
            D3_Attachments = new HashSet<D3_Attachment>();
          
        }
        public int Id { get; set; }
        public bool? CopyFromD0 { get; set; }
        

        public Guid ReportHeaderId { get; set; }
        public virtual ReportHeader ReportHeader { get; set; }

        public virtual ICollection<D3_Action> D3_Actions { get; set; }

        public virtual ICollection<D3_Attachment> D3_Attachments { get; set; }
    }
}

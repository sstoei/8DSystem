using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class WorkFlow
    {
        public int Id { get; set; }
       
        public string ActionId { get; set; }
        public string ActionEmail { get; set; }
        public int ApproveId { get; set; }
        public int CancelId { get; set; }
        public int PreviousId { get; set; }
        public StatusId RefStatusId { get; set; }
        public virtual RefStatus RefStatus { get; set; }
    }
}

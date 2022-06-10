using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D0_EmergencyRespondAction
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string TeamMemberId { get; set; }
        public string TeamMemberName { get; set; }
        public string TeamMemberEmail { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateFinish { get; set; }
        public string Metric { get; set; }
        public string Eff { get; set; }
        public string PartId { get; set; }
        public int D0Id { get; set; }
        public virtual D0 D0 { get; set; }

    }
}

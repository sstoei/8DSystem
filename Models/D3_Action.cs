using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D3_Action
    {
        public int Id { get; set; }
        public string D3_Detail { get; set; }
        [StringLength(7)]
        public string D3_TeamMember { get; set; }
        public string D3_TeamMemberName { get; set; }
        public string D3_TeamMemberEmail { get; set; }
        public DateTime? D3_DateStart { get; set; }
        public DateTime? D3_DateFinish { get; set; }
        public decimal? D3_Metric { get; set; }
        public decimal? D3_Eff { get; set; }
        public string D3_PartId { get; set; }
        public int D3Id { get; set; }
        public virtual D3 D3 { get; set; }
    }
}

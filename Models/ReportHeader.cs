using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class ReportHeader
    {
        public ReportHeader()
        {
            D0s = new HashSet<D0>();
            D1s = new HashSet<D1>();
            D2s = new HashSet<D2>();
            D3s = new HashSet<D3>();
            D4s = new HashSet<D4>();
            D5s = new HashSet<D5>();
            D6s = new HashSet<D6>();
            D7s = new HashSet<D7>();
            D8s = new HashSet<D8>();
        }
        public Guid Id { get; set; }
        public DateTime? DateOpened { get; set; }
        public DateTime? DateTargetedClosure { get; set; }
        public DateTime? DateClosed { get; set; }
        public DateTime? DateClosureD0 { get; set; }
        public DateTime? DateClosureD1 { get; set; }
        public DateTime? DateClosureD2 { get; set; }
        public DateTime? DateClosureD3 { get; set; }
        public DateTime? DateClosureD4 { get; set; }
        public DateTime? DateClosureD5 { get; set; }
        public DateTime? DateClosureD6 { get; set; }
        public DateTime? DateClosureD7 { get; set; }
        public DateTime? DateClosureD8 { get; set; }
        public DateTime? DateEffectivenessCheck  { get; set; }
        public DateTime? DateCreate  { get; set; } = DateTime.Now;
        [StringLength(7)]
        public string CreateBy  { get; set; }
        public string CreateByName  { get; set; }
        public string CreateByEmail  { get; set; }
        public string NcrNo  { get; set; }
        [Required]
        [StringLength(13)]
        public string Code  { get; set; }
        public int WorkFlowId { get; set; }
        public virtual WorkFlow WorkFlow { get; set; }
        public virtual ICollection<D0> D0s { get; set; }
        public virtual ICollection<D1> D1s { get; set; }
        public virtual ICollection<D2> D2s { get; set; }
        public virtual ICollection<D3> D3s { get; set; }
        public virtual ICollection<D4> D4s { get; set; }
        public virtual ICollection<D5> D5s { get; set; }
        public virtual ICollection<D6> D6s { get; set; }
        public virtual ICollection<D7> D7s { get; set; }
        public virtual ICollection<D8> D8s { get; set; }
    }
}

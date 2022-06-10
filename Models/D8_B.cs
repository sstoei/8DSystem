using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D8_B
    {
        public int Id { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Signature1 { get; set; }
        public string Signature2 { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }

        public int D8Id { get; set; }
        public virtual D8 D8 { get; set; }
    }
}

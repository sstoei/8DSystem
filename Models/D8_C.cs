using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D8_C
    {
        public int Id { get; set; }
        public string When { get; set; }
        public string Where { get; set; }
        public string How { get; set; }

        public int D8Id { get; set; }
        public virtual D8 D8 { get; set; }
    }
}

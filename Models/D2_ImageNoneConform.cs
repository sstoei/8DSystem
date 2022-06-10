using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D2_ImageNoneConform
    {
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        [Required]
        public byte[] Content { get; set; }
        [Required]
        public string ContentName { get; set; }
        [Required]
        public string ContentMimeType { get; set; }
        
        public int D2Id { get; set; }
        public virtual D2 D2 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D5_Attachment
    {
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        [Required]
        public byte[] Content { get; set; }
        [Required]
        public string ContentName { get; set; }
        [Required]
        public string ContentMimeType { get; set; }
        
        public int D5Id { get; set; }
        public virtual D5 D5 { get; set; }
    }
}

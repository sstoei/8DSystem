using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class RefStatus
    {
        public RefStatus()
        {
            WorkFlow = new HashSet<WorkFlow>();
        }
        public StatusId Id { get; set; }
        public int Step { get; set; }
        public string Name { get; set; }
        public string Behavior { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<WorkFlow> WorkFlow { get; set; }
    }
    public enum StatusId
    {
        Draft = 1,
        Inprocess = 2,
        WaitingApprove = 3,
        Completed =4,
        Rejected = 5,
        MgrApproved = 6

    }
}

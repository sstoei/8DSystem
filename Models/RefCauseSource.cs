using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class RefCauseSource
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
    //public enum RefCauseSourceId {
    //    FailureMechanism = 1,
    //    EscapePoint = 2,
    //    QMSIssue = 3
    //}
}

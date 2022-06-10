using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models.Views
{
    public struct CreateReference
    {
        public List<EmpSection> EmpSections { get; set; }
        public List<EmpInfo> EmpInfos { get; set; }
        public List<EmpDepartment> EmpDepartments { get; set; }
        public List<RefCauseSource> RefCauseSources { get; set; }
        public List<RefFunction> RefFunctions { get; set; }
        public List<RefPCAStatus> RefPCAStatuses { get; set; }
        public List<WorkFlow> WorkFlows { get; set; }
        public ReportHeader ReportHeaders { get; set; }

    }
}

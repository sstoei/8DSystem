using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class EmpInfo
    {
        public string EmpId { get; set; }
        public string EmpDomainId { get; set; }
        public string EmpNickName { get; set; }
        public string EmpTitle { get; set; }
        public string EmpFullname { get; set; }
        public string EmpTitleEN { get; set; }
        public string EmpFullnameEN { get; set; }
        public string EmpGender { get; set; }
        public string EmpPositionId { get; set; }
        public string EmpPositionName { get; set; }
        public string EmpLevel { get; set; }
        public string EmpLevelName { get; set; }
        public string EmpSectionId { get; set; }
        public string EmpSectionName { get; set; }
        public string EmpDepartmentId { get; set; }
        public string EmpDepartmentName { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPhoneExt { get; set; }
        public string EmpMobile { get; set; }
        public string EmployeeType { get; set; }
        public string SupervisorId { get; set; }
        public string SupervisorEmail { get; set; }
        public string ManagerId { get; set; }
        public string ManagerEmail { get; set; }
        public DateTime? TerminateDate { get; set; }
        public int EmpStatus { get; set; }
    }
}

using _8DSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Services
{
    public interface IUserService
    {
        EmpInfo GetCurrentEmpInfo(string userId);
        EmpInfo GetEmpInfo(string empId);
        EmpInfo GetEmpInfoByCode(string codeId);
   
    }
}

using _8DSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Services
{
    public class UserService : IUserService
    {
        private readonly CoreContext _db;
        public UserService(CoreContext db)
        {
            _db = db;
        }
        public EmpInfo GetEmpInfoByCode(string codeId)
            => _db.EmpInfo.FirstOrDefault(w => w.EmpId == codeId);
        public EmpInfo GetEmpInfo(string empId)
            => _db.EmpInfo.FirstOrDefault(w => w.EmpDomainId == empId);
        public List<EmpInfo> GetEmpInfos()
            => _db.EmpInfo.ToList();
        public EmpInfo GetCurrentEmpInfo(string userId)
            => _db.EmpInfo.FirstOrDefault(w => w.EmpDomainId == userId);
    }
}

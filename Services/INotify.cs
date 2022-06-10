using _8DSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Services
{
    public interface INotify
    {
        void SendEmail(ReportHeader report);
    }
}

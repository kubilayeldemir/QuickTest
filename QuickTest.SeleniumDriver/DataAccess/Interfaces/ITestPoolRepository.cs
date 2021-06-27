using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ITestPoolRepository
    {
        public Task<Testcase> GetATestcaseFromPool();
    }
}

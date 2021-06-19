using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ITestcaseRepository
    {
        public Task<List<Testcase>> GetAllTestcases();
    }
}

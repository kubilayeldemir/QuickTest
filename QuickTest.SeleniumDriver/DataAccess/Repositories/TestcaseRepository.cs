using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class TestcaseRepository:ITestcaseRepository
    {
        private readonly IClient client;

        public TestcaseRepository(IClient client)
        {
            this.client = client;
        }

        public async Task<List<Testcase>> GetAllTestcases()
        {
            return await client.GetAsync<List<Testcase>>("testcase");
        }

    }
}

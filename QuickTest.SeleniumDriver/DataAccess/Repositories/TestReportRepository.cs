using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class TestReportRepository:ITestReportRepository
    {
        private readonly IClient client;
        public TestReportRepository(IClient client)
        {
            this.client = client;
        }
        public async Task<TestReport> PostTestReportAsync(TestReport testReport)
        {
            return await client.PostAsync<TestReport>("testcase/reports",testReport);
        }
    }
}

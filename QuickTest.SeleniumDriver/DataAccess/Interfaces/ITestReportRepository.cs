using DataAccess.Models;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface ITestReportRepository
    {
        public Task<TestReport> PostTestReportAsync(TestReport testReport);
    }
}
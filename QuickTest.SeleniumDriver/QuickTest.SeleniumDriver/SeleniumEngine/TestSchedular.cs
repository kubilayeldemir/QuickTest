using DataAccess.Interfaces;
using DataAccess.Repositories;
using QuickTest.SeleniumDriver.SeleniumEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickTest.SeleniumDriver.SeleniumEngine
{
    public class TestSchedular: ITestSchedular
    {
        private readonly ITestRunner testRunner;
        private readonly ITestcaseRepository testcaseRepository;
        private readonly ITestReportRepository testReportRepository;


        public TestSchedular(ITestRunner testRunner,ITestcaseRepository testcaseRepository, ITestReportRepository testReportRepository)
        {
            this.testcaseRepository = testcaseRepository;
            this.testRunner = testRunner;
            this.testReportRepository = testReportRepository;
        }

        public async Task GetAndRunFirstTestAsync()
        {
            var testCase = await testcaseRepository.GetAllTestcases();
            var testResult = testRunner.RunTest(testCase[0]);
            var x = await testReportRepository.PostTestReportAsync(testResult);
            Console.WriteLine(x.reportId);
        }
    }
}

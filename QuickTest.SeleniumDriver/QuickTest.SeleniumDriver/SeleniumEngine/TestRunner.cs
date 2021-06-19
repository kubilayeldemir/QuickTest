using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickTest.SeleniumDriver.SeleniumEngine
{
    public class TestRunner:ITestRunner
    {
        private readonly ITestcaseRepository testcaseRepository;
        public TestRunner(ITestcaseRepository testcaseRepository)
        {
            this.testcaseRepository = testcaseRepository;
        }
        public async Task<String> RunTestAsync()
        {
            var tests = await testcaseRepository.GetAllTestcases();
            return tests[0].testName;
        }
    }
}
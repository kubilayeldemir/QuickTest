using DataAccess.Interfaces;
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

        public TestSchedular(ITestRunner testRunner,ITestcaseRepository testcaseRepository)
        {
            this.testcaseRepository = testcaseRepository;
            this.testRunner = testRunner;
        }

        public async Task GetAndRunFirstTestAsync()
        {
            var testCase = await testcaseRepository.GetAllTestcases();
            testRunner.RunTest(testCase[0]);
        }
    }
}

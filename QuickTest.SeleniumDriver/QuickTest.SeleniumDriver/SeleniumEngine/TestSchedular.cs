﻿using DataAccess.Interfaces;
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
        private readonly ITestPoolRepository testPoolRepository;
        private readonly ITestReportRepository testReportRepository;


        public TestSchedular(ITestRunner testRunner, ITestPoolRepository testPoolRepository, ITestReportRepository testReportRepository)
        {
            this.testPoolRepository = testPoolRepository;
            this.testRunner = testRunner;
            this.testReportRepository = testReportRepository;
        }

        public async Task GetAndRunATestAsync()
        {
            var testCaseToRun = await testPoolRepository.GetATestcaseFromPool();
            var testResult = testRunner.RunTest(testCaseToRun);
            var x = await testReportRepository.PostTestReportAsync(testResult);
            Console.WriteLine(x.reportId);
        }
    }
}

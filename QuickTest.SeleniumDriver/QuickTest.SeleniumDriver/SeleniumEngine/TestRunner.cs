using DataAccess.Interfaces;
using DataAccess.Models;
using DataAccess.Models.Enums;
using DataAccess.Repositories;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuickTest.SeleniumDriver.SeleniumEngine
{
    public class TestRunner:ITestRunner
    {        
        private void RunTestStep(IWebDriver driver, Step step)
        {

        }
        public  TestReport RunTest(Testcase testCase)
        {
            var driver = new ChromeDriver();

            var testReport = new TestReport();
            testReport.testcaseId = testCase.id;
            testReport.status = false;
            testReport.testStartDate = DateTime.Now;

            
            foreach(Step step in testCase.steps)
            {
                switch(step.action)
                {
                    case TestAction.GoTo:
                        driver.Navigate().GoToUrl(step.actionText);
                        break;
                    case TestAction.Click:
                        By by;
                        if (step.by == FindElementBy.ClassName)
                        {
                            by = By.ClassName(step.elementAddress);
                        }
                        else
                        {
                            by = By.Id(step.elementAddress);
                        }
                        driver.FindElement(by).Click();
                        break;
                }
            }
            Thread.Sleep(5000);
            testReport.testEndDate = DateTime.Now;
            testReport.status = true;
            driver.Quit();
            return testReport;
        }
    }
}
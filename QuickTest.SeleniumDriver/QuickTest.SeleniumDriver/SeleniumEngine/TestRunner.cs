using DataAccess.Interfaces;
using DataAccess.Models;
using DataAccess.Models.Enums;
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
        private readonly ITestcaseRepository testcaseRepository;
        public TestRunner(ITestcaseRepository testcaseRepository)
        {
            this.testcaseRepository = testcaseRepository;
        }
        public  String RunTest(Testcase testCase)
        {
            var driver = new ChromeDriver();
            
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
            Thread.Sleep(11000);
            driver.Quit();
            return "";
        }
    }
}
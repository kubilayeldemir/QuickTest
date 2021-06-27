using DataAccess;
using DataAccess.Interfaces;
using DataAccess.Models;
using DataAccess.Models.Enums;
using DataAccess.Repositories;
using OpenQA.Selenium;
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
        public async  Task<TestReport> RunTestAsync(Testcase testCase)
        {
            
            var driver = new DriverFactory().createWebDriver();

            var testReport = new TestReport();
            testReport.testSteps = new List<ReportStep>();
            testReport.testcaseId = testCase.id;
            testReport.status = false;
            testReport.testStartDate = DateTime.Now;

            
            foreach(Step step in testCase.steps)
            {
                var testStep = new ReportStep();
                testStep.stepNumber = step.stepNumber;
                testStep.status = false;
                testStep.stepDate = DateTime.Now;
                testStep.stepDescription = step.ToString();
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
                        else if(step.by == FindElementBy.Xpath)
                        {
                            by = By.XPath(step.elementAddress);
                        }
                        else
                        {
                            by = By.Id(step.elementAddress);
                        }
                        driver.FindElement(by).Click();
                        break;
                    case TestAction.SendText:
                        if (step.by == FindElementBy.ClassName)
                        {
                            by = By.ClassName(step.elementAddress);
                        }
                        else if (step.by == FindElementBy.Xpath)
                        {
                            by = By.XPath(step.elementAddress);
                        }
                        else
                        {
                            by = By.Id(step.elementAddress);
                        }
                        driver.FindElement(by).SendKeys(step.actionText);
                        break;
                }
                testStep.status = true;
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                string fileName = testCase.testName + DateTime.Now.ToString()+".PNG";
                string imageLink = await AzureStorageHelper.UploadFileToStorage(fileName, ss.AsByteArray);
                testStep.stepImageUrl = imageLink;
                testReport.testSteps.Add(testStep);
                Thread.Sleep(1000);
            }
            Thread.Sleep(5000);
            testReport.testEndDate = DateTime.Now;
            testReport.status = true;
            driver.Quit();
            return testReport;
        }
    }
}
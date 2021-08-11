using DataAccess;
using DataAccess.Interfaces;
using DataAccess.Models;
using DataAccess.Models.Enums;
using DataAccess.Repositories;
using OpenQA.Selenium;
using QuickTest.SeleniumDriver.SeleniumEngine.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuickTest.SeleniumDriver.SeleniumEngine
{
    public class TestRunner:ITestRunner
    {
        public async  Task<TestReport> RunTestAsync(Testcase testCase)
        {            
            var driver = new DriverFactory().createWebDriver();

            bool isError = false;
            var testReport = new TestReport();
            testReport.testSteps = new List<ReportStep>();
            testReport.testcaseId = testCase.id;
            testReport.status = true;
            testReport.testStartDate = DateTime.Now;
            var sortedSteps = testCase.steps.OrderBy(x => x.stepNumber);

            ICommandFactory commandFactory = new CommandFactory(driver);

            foreach (Step step in sortedSteps)
            {
                var testStep = new ReportStep();
                testStep.stepNumber = step.stepNumber;
                testStep.status = true;
                testStep.stepDate = DateTime.Now;
                testStep.stepDescription = step.ToString();
                try
                {
                    ICommand command = commandFactory.getCommand(step);
                    command.Execute();
                    testStep.status = true;
                }
                catch (Exception e)
                {
                    testStep.status = false;
                    testReport.status = false;
                    isError = true;
                    testReport.errorMessage = e.Message.ToString();
                }
                finally
                {
                    Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                    string fileName = testCase.testName + DateTime.Now.ToString() + ".PNG";
                    fileName = fileName.Replace(' ', '_');
                    string imageLink = await AzureStorageHelper.UploadFileToStorage(fileName, ss.AsByteArray);
                    testStep.stepImageUrl = imageLink;
                    testReport.testSteps.Add(testStep);
                    Thread.Sleep(1000);
                }
                if (isError)
                {
                    break;
                }
            }
            Thread.Sleep(5000);
            testReport.testEndDate = DateTime.Now;
            driver.Quit();
            return testReport;
        }
    }
}
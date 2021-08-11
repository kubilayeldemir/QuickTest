using DataAccess.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTest.SeleniumDriver.SeleniumEngine.Command
{
    public class Command
    {
        protected IWebDriver driver;
        protected Step step;
        public Command(IWebDriver driver, Step testStep)
        {
            this.driver = driver;
            this.step = testStep;
        }
    }
}

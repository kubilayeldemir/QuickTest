using DataAccess.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTest.SeleniumDriver.SeleniumEngine.Command
{
    public class GoToCommand : Command, ICommand
    {
        public GoToCommand(IWebDriver driver,Step step) : base(driver,step) { }

        public void Execute()
        {
            driver.Navigate().GoToUrl(step.actionText);
        }
    }
}

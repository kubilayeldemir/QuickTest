using DataAccess.Models;
using DataAccess.Models.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTest.SeleniumDriver.SeleniumEngine.Command
{
    public class CommandFactory : ICommandFactory
    {
        IWebDriver driver;

        public CommandFactory(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ICommand getCommand(Step step)
        {
            switch (step.action)
            {
                case TestAction.GoTo:
                    return new GoToCommand(driver,step);
                case TestAction.Click:
                    return new ClickCommand(driver, step);
                case TestAction.SendText:
                    return new SendTextCommand(driver, step);
            }
            throw new Exception("Action not found");
        }
    }
}

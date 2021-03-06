using DataAccess.Models;
using OpenQA.Selenium;
using QuickTest.SeleniumDriver.SeleniumEngine.ElementFinder;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTest.SeleniumDriver.SeleniumEngine.Command
{
    public class ClickCommand : Command, ICommand
    {
        public ClickCommand(IWebDriver driver, Step step) : base(driver, step) { }

        public void Execute()
        {
            IElementFinder elementFinder = ElementFinderFactory.getElementFinder(step);
            var by = elementFinder.findElement();
            driver.FindElement(by).Click();
        }

    }
}

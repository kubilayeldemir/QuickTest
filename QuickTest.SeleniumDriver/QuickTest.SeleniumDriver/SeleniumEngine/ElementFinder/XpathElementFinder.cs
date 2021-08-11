using DataAccess.Models;
using DataAccess.Models.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTest.SeleniumDriver.SeleniumEngine.ElementFinder
{
    public class XpathElementFinder : ElementFinder, IElementFinder
    {
        public XpathElementFinder(Step step) : base(step) { }

        public By findElement()
        {
            return By.XPath(step.elementAddress);
        }
    }
}

using DataAccess.Models.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTest.SeleniumDriver.SeleniumEngine.ElementFinder
{
    public interface IElementFinder
    {
        By findElement();
    }
}

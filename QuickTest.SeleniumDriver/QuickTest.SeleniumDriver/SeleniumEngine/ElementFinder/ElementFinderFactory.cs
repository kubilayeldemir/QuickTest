using DataAccess.Models;
using DataAccess.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTest.SeleniumDriver.SeleniumEngine.ElementFinder
{
    public static class ElementFinderFactory
    {
        public static IElementFinder getElementFinder(Step step) {
            switch (step.by)
            {
                case FindElementBy.ClassName:
                    return new ClassNameElementFinder(step);
                case FindElementBy.Id:
                    return new IdElementFinder(step);
                case FindElementBy.Xpath:
                    return new XpathElementFinder(step);
                default:
                    return null;
            }
        }
    }
}

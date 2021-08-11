using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTest.SeleniumDriver.SeleniumEngine.ElementFinder
{
    public class ElementFinder
    {
        protected Step step;
        public ElementFinder(Step step)
        {
            this.step = step;
        }
    }
}

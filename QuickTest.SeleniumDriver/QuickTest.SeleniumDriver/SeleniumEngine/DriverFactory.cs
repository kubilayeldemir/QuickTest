using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTest.SeleniumDriver.SeleniumEngine
{
    public class DriverFactory
    {
        private int implicitWaitSeconds = 15;
        public IWebDriver createWebDriver()
        {
            IWebDriver driver = new ChromeDriver(fullScreen());
            setImplicitWait(driver, implicitWaitSeconds);
            return driver;
        }
        private ChromeOptions fullScreen()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return options;
        }
        public void setImplicitWait(IWebDriver driver, int seconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);

        }
    }
}

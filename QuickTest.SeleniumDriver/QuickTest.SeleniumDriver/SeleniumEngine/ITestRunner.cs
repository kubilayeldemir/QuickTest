using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickTest.SeleniumDriver.SeleniumEngine
{
    public interface ITestRunner
    {
        public Task<String> RunTestAsync();
    }
}

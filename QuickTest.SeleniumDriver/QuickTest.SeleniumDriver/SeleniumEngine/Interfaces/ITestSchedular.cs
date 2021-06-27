using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickTest.SeleniumDriver.SeleniumEngine.Interfaces
{
    public interface ITestSchedular
    {
        public Task GetAndRunATestAsync();
    }
}

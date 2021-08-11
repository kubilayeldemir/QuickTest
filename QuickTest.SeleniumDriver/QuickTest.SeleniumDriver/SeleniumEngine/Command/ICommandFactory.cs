using DataAccess.Models;
using DataAccess.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTest.SeleniumDriver.SeleniumEngine.Command
{
    public interface ICommandFactory
    {
        ICommand getCommand(Step step);
    }
}

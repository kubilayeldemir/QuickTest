using DataAccess.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Step
    {
        public TestAction action { get; set; }
        public string actionText { get; set; }
        public FindElementBy by { get; set; }
        public string elementAddress { get; set; }
        public long id { get; set; }
        public int stepNumber { get; set; }
        public override String ToString()
        {
            return action.ToString() + " Element address:" + elementAddress +
                " findElementBy:" + by.ToString() + " Action text:" + actionText +
                "Step number:" + stepNumber+" id:"+id;
        }
    }
}

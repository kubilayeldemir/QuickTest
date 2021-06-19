using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class ReportStep
    {
        public long reportStepId { get; set; }
        public bool status { get; set; }
        public DateTime stepDate { get; set; }
        public string stepDescription { get; set; }
        public string stepImageUrl { get; set; }
        public int stepNumber { get; set; }
    }
}

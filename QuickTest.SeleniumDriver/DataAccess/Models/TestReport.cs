using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class TestReport
    {
        public long reportId { get; set; }
        public long testcaseId { get; set; }

        public string errorMessage { get; set; }
        public string logFileURL { get; set; }
        public bool status { get; set; }
        public DateTime testEndDate { get; set; }
        public DateTime testStartDate { get; set; }
        public List<ReportStep> testSteps { get; set; }
    }
}

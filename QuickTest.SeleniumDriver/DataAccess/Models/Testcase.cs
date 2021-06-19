using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Testcase
    {
        public long id { get; set; }
        public string testName { get; set; }
        public string websiteAddress { get; set; }
        public List<Step> steps { get; set; }
    }
}

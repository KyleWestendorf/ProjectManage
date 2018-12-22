using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseClass
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Reseller { get; set; }
        public string Customer { get; set; }
        public string Product { get; set; }
    }
}
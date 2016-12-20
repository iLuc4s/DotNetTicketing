using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetTicketing.Models
{
    public class Issue
    {
        public string UserID { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public string Priority { get; set; }

        public string DateTime { get; set; }

        public string CreationDateTime { get; set; }
    }
}
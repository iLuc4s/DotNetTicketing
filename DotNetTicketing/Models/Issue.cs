using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DotNetTicketing.Models
{
    public class Issue
    {
        public int IssueId { get; set; }

        public int UserId { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public string Priority { get; set; }

        public int AssignedSolverId { get; set; }

        public string DateTime { get; set; }

        public string CreationDateTime { get; set; }

        public virtual User User { get; set; }
    }
}
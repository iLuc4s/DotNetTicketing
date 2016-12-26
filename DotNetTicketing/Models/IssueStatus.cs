using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DotNetTicketing.Models
{
    public class IssueStatus
    {
        public int IssueStatusId { get; set; }

        public string StatusName { get; set; }
    }
}
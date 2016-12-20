using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetTicketing.Models
{
    public class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string TelNumber { get; set; }

        public string CelNumber { get; set; }

        public string ResponsibleID { get; set; }

        public string RoleID { get; set; }
    }
}
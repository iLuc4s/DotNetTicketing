using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DotNetTicketing.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string TelNumber { get; set; }

        public string CelNumber { get; set; }

        public int ResponsibleId { get; set; }

        public int RoleID { get; set; }

        public virtual User Responsible { get; set; }

        public virtual Role Role { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DotNetTicketing.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        
        public string RoleName { get; set; }

        public Role(int IDer, string Rolename)
        {
            this.Id = IDer;
            this.RoleName = Rolename;
        }
    }
}
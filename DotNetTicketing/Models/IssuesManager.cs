using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetTicketing.Models
{
    public class IssuesManager
    {

        public List<Issue> Issues { get; set; }

        public IssuesManager()
        {
            /* Alle database issues inladen*/
        }

        public List<Issue> GetAllIssues() //Enkel Admin kan deze pakken.
        {
            return Issues;
        }

        public List<Issue> GetMyCreatedIssues(int UserId)
        {
            List<Issue> MyCreations = new List<Issue>();

            foreach (Issue i in Issues)
            {
                if(i.UserId == UserId) {
                    MyCreations.Add(i);
                }
            }
            return MyCreations;
        }
        public List<Issue> GetMyAssignedIssues(int UserId)
        {
            List<Issue> MyTickets = new List<Issue>();

            foreach (Issue i in Issues)
            {
                if (i.AssignedSolverId == UserId)
                {
                    MyTickets.Add(i);
                }
            }
            return MyTickets;
        }


    }
}
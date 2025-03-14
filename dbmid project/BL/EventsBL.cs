using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class EventsBL
    {
        public string eventName;
        public string category;
        public string description;
        public DateTime Date;
        public string venue;
        public List<CommitteeBL> committees;

        public EventsBL(string a, string b, string c, DateTime d, string e)
        {
            this.eventName = a;
            this.category = b;
            this.description = c;
            this.Date = d;
            this.venue = e;
            committees = new List<CommitteeBL>();
        }
    }
}

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
        public string Date;
        public string venue;
        public string committee;

        public EventsBL(string a, string b, string c, string d, string e, string f)
        {
            this.eventName = a;
            this.category = b;
            this.description = c;
            this.Date = d;
            this.venue = e;
            this.committee = f;
        }
    }
}

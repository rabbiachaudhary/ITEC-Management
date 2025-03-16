using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class DutiesDL
    {
        public string committee;
        public string member;
        public string taskdesc;
        public string date;
        public string status;
        public DutiesDL(string a, string b, string c, string d, string e)
        {
            this.committee = a;
            this.member = b;
            this.taskdesc = c;
            this.date = d;
            this.status = e;
        }
    }
}

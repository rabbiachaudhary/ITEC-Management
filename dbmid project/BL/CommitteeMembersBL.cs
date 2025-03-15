using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class CommitteeMembersBL
    {
        public string name;
        public string role;
        public string cmmmittee;

        public CommitteeMembersBL(string a,string b,string c)
        {
            this.name = a;
            this.role = b;
            this.cmmmittee = c;
        }
    }
}

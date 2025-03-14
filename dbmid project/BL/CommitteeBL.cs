using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class CommitteeBL
    {
        public int itecid;
        public string name;

        public CommitteeBL(int a,  string b)
        {
            this.name = b;
            this.itecid = a;
        }
    }
}

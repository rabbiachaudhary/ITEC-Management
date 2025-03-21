using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class SponsorBL
    {
        public string name;
        public string contact;
        public SponsorBL(string a, string b)
        {
            name = a;
            contact = b;
        }
    }
}

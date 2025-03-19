using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class VendorsBL
    {
        public string name;
        public string contact;
        public string type;
        public VendorsBL(string a, string b, string c)
        {
            this.name = a;
            this.contact = b;
            this.type = c;
        }
    }
}

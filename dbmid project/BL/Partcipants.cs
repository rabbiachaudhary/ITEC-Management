using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class Partcipants
    {
        public string name;
        public string email;
        public string contact;
        public string institute;
        public string role;
        public Partcipants(string a, string b, string c, string d, string e)
        {
            this.name = a;
            this.email = b;
            this.contact = c;
            this.institute = d;
            this.role = e;
        }
    }
}

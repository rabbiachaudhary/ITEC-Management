using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    public class usersBL
    {
        public string username;
        public string password;
        public string email;
        public string role;
        public string cpass;
        public usersBL() { }
        public usersBL(string a, string b, string c, string d, string e)
        {
            this.username = a;
            this.password = b;
            this.email = c;
            this.role = d;
            this.cpass = e;
        }
    }
}

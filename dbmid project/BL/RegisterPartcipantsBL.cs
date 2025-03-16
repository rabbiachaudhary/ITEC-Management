using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class RegisterPartcipantsBL
    {
        public string participant;
        public string eventn;
        public string status;
        public int fees;
        public RegisterPartcipantsBL(string a, string b, string c, int d)
        {
            participant = a;
            eventn = b;
            status = c;
            fees = d;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class venueBL
    {
        public string name;
        public string location;
        public int capacity;
        
        public venueBL(string a, string b, int c)
        {
            this.name = a;
            this.location = b;
            this.capacity = c;
        }
    }
}

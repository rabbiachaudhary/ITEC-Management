using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class ITECeditionBL
    {
        public int year;
        public string theme;
        public string description;
        public ITECeditionBL(int a, string b, string c)
        {
            this.year = a;
            this.theme = b;
            this.description = c;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class TransactionsBL
    {
        public string eventn;
        public string FinanceType;
        public float amount;
        public string description;
        public string date;
        public string sname;
        public string stype;
        public string rname;
        public string rtype;
        public TransactionsBL(string a, string b, float c, string d, string e, string f, string g, string h, string i)
        {
            this.eventn = a;
            this.FinanceType = b;
            this.amount = c;
            this.description = d;
            this.date = e;
            this.sname = f;
            this.stype = g;
            this.rname = h;
            this.rtype = i;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class ResultsBL
    {
        public string event_name;

        public string participant;
        public string team;
        public string position;
        public float score;
        public string remarks;


        public ResultsBL(string a, string b, string c, string d, float e, string f)
        {
            this.event_name = a;
            this.participant = b;
            this.team = c;
            this.position = d;
            this.score = e;
            this.remarks = f;
        }s
    }
}

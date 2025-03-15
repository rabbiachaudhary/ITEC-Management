using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using sqlhelper;

namespace dbmid_project.DL
{
    internal class CommitteeDL
    {
        public static void AddCommittee(CommitteeBL c)
        {
            string query = "INSERT INTO committees (itec_id, committee_name) VALUES ({0}, '{1}')";
            query = string.Format(query, c.itecid,c.name);
            SqlHelper.executeDML(query);
            MessageBox.Show("Committee added successfully");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using sqlhelper;

namespace dbmid_project.DL
{
    internal class CommitteeMembersDL
    {

        public static void AddCommittee(CommitteeMembersBL c)
        {
            string com = "select committee_id from committees where committee_name='{0}'";
            com = string.Format(com, c.cmmmittee);
            int comid=SqlHelper.GetRole(com);


            string role = "select lookup_id from lookup where value='{0}'";
            role=string.Format(role, c.role);
            int roleid=SqlHelper.GetRole(role);


            string query = "INSERT INTO committee_members (committee_id,name,role_id) VALUES ({0}, '{1}',{2})";
            query = string.Format(query, comid, c.name,roleid);
            SqlHelper.executeDML(query);
            MessageBox.Show("Committee Member added successfully");
        }


    }
}

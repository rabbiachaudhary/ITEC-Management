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

        public static void Delete(string name)
        {
            string sql = "delete from committee_members where name='{0}'";
            sql = string.Format(sql, name);
            SqlHelper.executeDML(sql);

            MessageBox.Show("Deleted");
        }

        public static void Update(string oldname, string newn, string com, string role)
        {
            string coms = "select committee_id from committees where committee_name='{0}'";
            coms = string.Format(coms, com);
            int comid = SqlHelper.GetRole(coms);


            string rolei = "select lookup_id from lookup where value='{0}'";
            rolei = string.Format(rolei, role);
            int roleid = SqlHelper.GetRole(rolei);

            string member = "select member_id from committee_members where name='{0}'";
            member = string.Format(member, oldname);
            int mem_id=SqlHelper.GetRole(member);

            string sql = "Update committee_members set name='{0}' , committee_id={1}, role_id={2} where member_id={3}  ";
            sql=string.Format(sql, newn,comid,roleid,mem_id);
            SqlHelper.executeDML(sql);
            MessageBox.Show("Updated ");
        }

    }
}

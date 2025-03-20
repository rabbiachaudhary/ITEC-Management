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
            string exist = "SELECT Count(*) From committees where itec_id={0} and committee_name='{1}'";
            exist = string.Format(exist, c.itecid,c.name);
            int count = SqlHelper.CountRows(exist);
            if (count > 0)
            {
                MessageBox.Show("This Committee Already Exists");
            }

            else
            {

                string query = "INSERT INTO committees (itec_id, committee_name) VALUES ({0}, '{1}')";
                query = string.Format(query, c.itecid, c.name);
                SqlHelper.executeDML(query);
                MessageBox.Show("Committee added successfully");
            }
        }


        public static void Update(string newn,string com)
        {
            string idcom = "select committee_id from committees where committee_name='{0}'";
            idcom = string.Format(idcom, com);

            int id = SqlHelper.GetRole(idcom);

            string sql = "update committees set committee_name='{0}' WHERE committee_id={1} ";
            sql = string.Format(sql, newn, id);

            SqlHelper.executeDML(sql);
        }


        public static void Delete(string com)
        {
            string idcom = "select committee_id from committees where committee_name='{0}'";
            idcom = string.Format(idcom, com);
            
            int id = SqlHelper.GetRole(idcom);


            MessageBox.Show(id.ToString());

            string sql = "delete from committees where committee_id={0}";
            sql = string.Format(sql, id);
            SqlHelper.executeDML(sql);
        }
    }
}

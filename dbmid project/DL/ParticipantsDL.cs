using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dbmid_project.BL;
using sqlhelper;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace dbmid_project.DL
{
    internal class ParticipantsDL
    {
        public static void AddEvent(Partcipants p)
        {
            int year = ITECedi.GetItec_Year();

            string query = "insert into participants(itec_id, name, email,contact,institute, role_id)   select (select itec_id from itec_editions where year={0}), '{1}','{2}','{3}','{4}',(Select role_id from roles where role_name='{5}')";
            query = string.Format(query, year,p.name, p.email , p.contact,p.institute, p.role);
            MessageBox.Show(query);
            SqlHelper.executeDML(query);
            MessageBox.Show("Participant added successfully");
        }


        public static void DeletePartcipant(string e)
        {

            string sql = "delete from participants where name='{0}'";
            sql = string.Format(sql, e);
            SqlHelper.executeDML(sql);
            MessageBox.Show("Deleted");
        }


        public static void Update(string oname,string  newname,string email,string con,string instituite,string role)
        {
            string ids = "select participant_id from participants where name = '{0}'";
            ids = string.Format(ids, oname);
            int id=SqlHelper.GetRole(ids);


            string sql = "update participants set name='{0}' , email='{1}', contact='{2}', institute='{3}', role_id=(Select role_id from roles where role_name='{4}')  where participant_id={5}";
            sql = string.Format(sql,newname,email,con,instituite,role,id);
            MessageBox.Show(sql);

            SqlHelper.executeDML(sql);
            MessageBox.Show("Updated");
        }
    }
}

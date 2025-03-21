using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using sqlhelper;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Crypto;
namespace dbmid_project.DL
{
    internal class ITECeditionDL
    {
        public static void AddEdition(ITECeditionBL ITEC)
        {
            string exist = " SELECT Count(*) From itec_editions where year = {0}";
            exist = string.Format(exist, ITEC.year);
            int count=SqlHelper.CountRows(exist);
            if (count > 0)
            {
                MessageBox.Show("An Edition With Same Year Already Exists");
            }
            else
            {


                string query = "INSERT INTO itec_editions (year,theme,description) VALUES ('{0}', '{1}', '{2}')";
                query = string.Format(query, ITEC.year, ITEC.theme, ITEC.description);
                SqlHelper.executeDML(query);
                MessageBox.Show("Edition added successfully");

            }
        }


        public static void UpdateEdition(string old, ITECeditionBL i)
        {
            string exist = " SELECT Count(*) From itec_editions where year = {0}";
            exist = string.Format(exist, i.year);
            int count = SqlHelper.CountRows(exist);
            if (count > 0)
            {
                MessageBox.Show("An Edition With Same Year Already Exists");
            }

            else
            {

                string sql= "select itec_id from itec_editions where year ={0}";
                sql = string.Format(sql,old);

                int id = SqlHelper.GetRole(sql);

                string query = "UPDATE ITEC_editions set year={0},theme='{1}', description='{2}' where itec_id={3}";
                query = string.Format(query, i.year, i.theme, i.description, id);
                SqlHelper.executeDML(query);
                MessageBox.Show("Edition updated successfully");

            }
        }

            public static void DeleteEdition(string  year)
            {
                string query = "DELETE FROM itec_editions WHERE year={0}";
                query = string.Format(query, year);
                SqlHelper.executeDML(query);
                MessageBox.Show("Itec Edtiton " + year + " deleted successfully");
            } 
        
    }
}

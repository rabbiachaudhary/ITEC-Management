using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using sqlhelper;
using Microsoft.VisualBasic.ApplicationServices;
namespace dbmid_project.DL
{
    internal class ITECeditionDL
    {
        public static void AddEdition(ITECeditionBL ITEC)
        {
            string exist = "Count(*) From itec_editions where year = {0}";
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
    }
}

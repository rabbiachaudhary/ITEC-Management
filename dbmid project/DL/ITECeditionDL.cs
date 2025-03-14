using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using MessagingSystem;
using Microsoft.VisualBasic.ApplicationServices;
namespace dbmid_project.DL
{
    internal class ITECeditionDL
    {
        public static void AddEdition(ITECeditionBL ITEC)
        {
            string query = "INSERT INTO itec_editions (year,theme,description) VALUES ('{0}', '{1}', '{2}')";
            query = string.Format(query,ITEC.year, ITEC.theme,ITEC.description);
            SqlHelper.executeDML(query);
            MessageBox.Show("Edition added successfully");
        }
    }
}

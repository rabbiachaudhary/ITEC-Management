using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using sqlhelper;

namespace dbmid_project.DL
{
    internal class SponsorsDL
    {
        public static void Adds(SponsorBL v)
        {

            string query = "INSERT INTO sponsors(sponsor_name,contact) VALUES ('{0}','{1}')";
            query = string.Format(query, v.name, v.contact);
            SqlHelper.executeDML(query);
            MessageBox.Show("Sponsor added Successfully");
        }

        public static void Delete(string name)
        {
            string query = "DELETE FROM sponsors where sponsor_name='{0}'";
            query = string.Format(query, name);
            SqlHelper.executeDML(query);
            MessageBox.Show("Sponsor " + name + "Successfully Deleted");
        }

        public static void UpdateVendorInfo(string oldname, SponsorBL update)
        {
            string query = "UPDATE sponsors SET sponsor_name='{0}', contact='{1}'  sponsor_id=(select sponsor_id where vendor_name='{2}')";
            query = string.Format(query, update.name, update.contact,  oldname);
            SqlHelper.executeDML(query);
            MessageBox.Show("Sponsor Info Updated");
        }

    }
}

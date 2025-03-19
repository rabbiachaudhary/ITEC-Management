using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dbmid_project.BL;
using Mysqlx.Crud;
using sqlhelper;
namespace dbmid_project.DL
{
    internal class VendorsDL
    {
        public static void AddVendors(VendorsBL v)
        {
            string query = "INSERT INTO vendors (vendor_name, contact, service_type) VALUES ('{0}',{1}','{2}')";
            query = string.Format(query, v.name, v.contact, v.type);
            SqlHelper.executeDML(query);
            MessageBox.Show("Vendor added Successfully");
        }

        public static void DeleteVendor(string name)
        {
            string query = "DELETE FROM vendors WHERE vendor_name='{0}'";
            query = string.Format(query, name);
            SqlHelper.executeDML(query);
            MessageBox.Show("Vendor " + name + "Successfully Deleted");
        }

        public static void UpdateVendorInfo(string oldname,VendorsBL update)
        {
            string query = "UPDATE vendors SET vendor_name='{0}', contact='{1}', service_type='{2}'   vendor_id=(select vendor_id where vendor_name='{3}')";
            query = string.Format(query, update.name, update.contact, update.type, oldname);
            SqlHelper.executeDML(query);
            MessageBox.Show("Vendor Info Updated");
        }


    }
}

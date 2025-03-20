using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using sqlhelper;

namespace dbmid_project.DL
{
    internal class venueDL
    {
        public static void AddVenue(venueBL venue)
        {
            string exist = "Count(*) From venues where venue_name='{0}' ";
            exist = string.Format(exist, venue.name);
            int count = SqlHelper.CountRows(exist);
            if (count > 0)
            {
                MessageBox.Show("This venue alredy exits");
            }
            else
            {
                string query = "INSERT INTO venues (venue_name,capacity,location) VALUES ('{0}', '{1}', '{2}')";
                query = string.Format(query, venue.name, venue.capacity, venue.location);
                SqlHelper.executeDML(query);
                MessageBox.Show("Venue added successfully");
            }
        
        }
    }
}

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
            string query = "INSERT INTO venues (venue_name,capacity,location) VALUES ('{0}', '{1}', '{2}')";
            query = string.Format(query,venue.name,venue.capacity,venue.location);
            SqlHelper.executeDML(query);
            MessageBox.Show("Venue added successfully");
        }
    }
}

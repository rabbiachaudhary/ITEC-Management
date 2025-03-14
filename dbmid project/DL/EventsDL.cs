using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using MessagingSystem;

namespace dbmid_project.DL
{
    internal class EventsDL
    {
        public static void AddEvent(EventsBL e)
        {
            int year = ITECedi.GetItec_Year();
            string sql = "select itec_id from itec_editions where year={0}";
            sql=string.Format(sql, year);
            int itec_id = SqlHelper.GetRole(sql);

            string sqlCategory = "SELECT event_category_id from event_categories where category_name='{0}'";
            sqlCategory = string.Format(sqlCategory, e.category);

            string sqlVenue = "SELECT venue_id from venues where venue_name='{0}'";
            sqlVenue = string.Format(sqlCategory, e.venue);

            string query = "INSERT INTO itec_events (itec_id,event_name,event_category_id,description,event_date,venue_id,committee_id) VALUES ('{0}', '{1}', '{2}')";
            query = string.Format(query, ITEC.year, ITEC.theme, ITEC.description);
            SqlHelper.executeDML(query);
            MessageBox.Show("Edition added successfully");
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using sqlhelper;

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
            int category_id = SqlHelper.GetRole(sqlCategory);


            string sqlCommittee = "SELECT committee_id from committees where committee_name='{0}'";
            sqlCommittee = string.Format(sqlCommittee, e.committee);
            int com_id = SqlHelper.GetRole(sqlCommittee);


            string sqlVenue = "SELECT venue_id from venues where venue_name='{0}'";
            sqlVenue = string.Format(sqlVenue, e.venue);
            int venue_id=SqlHelper.GetRole(sqlVenue);

            string venue = "select count(*) from itec_events i join venues v on v.venue_id=i.venue_id where venue_name='{0}' and event_date='{1}'";
            venue = string.Format(venue, e.venue, e.Date); 
            int c=SqlHelper.CountRows(venue);
            if (c > 0)
            {
                MessageBox.Show("This venue at this time is occupied");
            }
            else
            {
                string exist = " SELECT Count(*) From Itec_events where itec_id={0} and event_name='{1}'";
                exist = string.Format(exist, itec_id, e.eventName);
                int count = SqlHelper.CountRows(exist);
                if (count > 0)
                {
                    MessageBox.Show("This Event Already Exists");
                }
                else
                {
                    string query = "INSERT INTO itec_events (itec_id,event_name,event_category_id,description,event_date,venue_id,committee_id) VALUES ({0}, '{1}', {2},'{3}','{4}',{5},{6})";
                    query = string.Format(query, itec_id, e.eventName, category_id, e.description, e.Date, venue_id, com_id);
                    SqlHelper.executeDML(query);


                    string venueall = "INSERT into venue_allocations (event_id,venue_id, assigned_date, assigned_time) VALUES ((select event_id from itec_events where event_name='{0}'), (select venue_id from venues where venue_name='{1}'), '{2}', NOW()   )";

                    venueall = string.Format(venueall, e.eventName, e.venue, e.Date);

                    SqlHelper.executeDML(venueall);
                    

                    MessageBox.Show("Event added successfully");
                }
            }
        }
        
        public static void DeleteEvent(string e)
        {

            string idstr = "select event_id from itec_events where event_name='{0}'";
            idstr = string.Format(idstr, e);

            int id = SqlHelper.GetRole(idstr);



            string sql = "delete from itec_events where event_id={0}";
            sql = string.Format(sql, id);
            SqlHelper.executeDML(sql);

            MessageBox.Show("Deleted");
        }

        public static void Update(string eventn,  string newvenue,string  catnew, string date,string  newcom,string newdes)
        {

            string idstr = "select event_id from itec_events where event_name='{0}'";
            idstr = string.Format(idstr, eventn);

            int id = SqlHelper.GetRole(idstr);


            string sqlCategory = "SELECT event_category_id from event_categories where category_name='{0}'";
            sqlCategory = string.Format(sqlCategory, catnew);
            int category_id = SqlHelper.GetRole(sqlCategory);



            string sqlCommittee = "SELECT committee_id from committees where committee_name='{0}'";
            sqlCommittee = string.Format(sqlCommittee, newcom);
            int com_id = SqlHelper.GetRole(sqlCommittee);


            string sqlVenue = "SELECT venue_id from venues where venue_name='{0}'";
            sqlVenue = string.Format(sqlVenue, newvenue);
            int venue_id = SqlHelper.GetRole(sqlVenue);


            string sql= "update itec_events set event_name='{0}',event_category_id={1}, description='{2}', event_date='{3}', venue_id={4}, committee_id={5} WHERE event_id={6} ";
            sql = string.Format(sql, eventn, category_id, newdes, date, venue_id, com_id, id);


            SqlHelper.executeDML(sql);
            MessageBox.Show("Updated");
        }



    }
}

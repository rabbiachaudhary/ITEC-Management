using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sqlhelper;
namespace dbmid_project.DL
{
    internal class ReportsDL
    {
        public static DataTable Getreport(string reporttype)
        {
            int year = ITECedi.GetItec_Year();
            DataTable dt = new DataTable();
            string query = "";
            if(reporttype =="Participants Reports")
            {
                query = "select name, event_name, value, role_name from event_participants ep " +
                    "join participants p on p.participant_id=ep.participant_id " +
                    "join itec_events i on i.event_id=ep.event_id " +
                    "join lookup l on l.lookup_id=ep.payment_status_id " +
                    "join roles r on r.role_id=p.role_id  " +
                    "join itec_editions ie on i.itec_id=ie.itec_id " +
                    "where year={0}";
                query=string.Format(query, year);

            }
            if(reporttype== "Venue Allocations")
            {
                query = "select event_name, venue_name  ,assigned_date from venue_allocations v join itec_events i on i.event_id=v.event_id join venues s on s.venue_id=v.venue_id join itec_editions ie on i.itec_id=ie.itec_id where year={0}";
                query = string.Format(query, year);

            }

            if (reporttype== "Event Schedule Reports")
            {
                query = "select event_name, category_name, description, event_date, venue_name, committee_name from itec_events e " +
                    "join event_categories ec on e.category_id=ec.category_id " +
                    "join venues v on v.venue_id=e.venue_id " +
                    "join committees c on e.committee_id=c.committee_id " +
                    "join itec_editions ie on e.itec_id=ie.itec_id " +
                    "where year={0}";
                query = string.Format(query, year);

            }

            if(reporttype== "Committee Assignment Reports")
            {
                query = "select committee_name, assigned_to, task_description, deadline, value" +
                    " from duties d join committees c on c.committee_id=d.committee_id " +
                    " join lookup l on l.lookup_id=d.status_id";

            }

            if(reporttype== "Financial Reports")
            {
                query = "select event_name,value,amount,from_entity_type, to_entity_type, description, date_recorded from finances f" +
                    " join events e on f.event_id=e.event_id " +
                    "join lookup l on l.lookup_id=f.type_id  " +
                    "join itec_editions ie on f.itec_id = ie.itec_id " +
                    "where year={0}";
                query = string.Format(query, year);

            }
            dt =SqlHelper.getDataTable(query);
            return dt;
        }
    }
}

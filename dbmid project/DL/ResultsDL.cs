using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using sqlhelper;

namespace dbmid_project.DL
{
    internal class ResultsDL
    {
        public static void AddResults(ResultsBL r)
        {
            int year = ITECedi.GetItec_Year();

            string query = "INSERT INTO event_results (event_id, participant_id,team_id,position,score, remarks) VALUES ( " +
                "(select event_id from itec_events where event_name='{0}')," +
                "(select participant_id from participants where name='{1}')," +
                "(select team_id from teams where team_name='{2}')," +
                "'{3}',{4},'{5}'    )";
            query = string.Format(query,r.event_name, r.participant, r.team, r.position,r.score, r.remarks);
            SqlHelper.executeDML(query);
            MessageBox.Show("Result added successfully");
        }
    }
}

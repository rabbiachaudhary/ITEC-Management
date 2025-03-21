using System;
using System.Collections.Generic;
using dbmid_project.BL;
using sqlhelper;

namespace dbmid_project.DL
{
    internal class teamsDL
    {
        public static void AddTeam(teams t)
        {
            try
            {
                string query = "INSERT INTO teams (event_id, team_name) VALUES ((SELECT event_id FROM itec_events WHERE event_name = '{0}'), '{1}')";
                query = string.Format(query, t.eventn, t.team_name);
                SqlHelper.executeDML(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding team: " + ex.Message);
            }
        }

        public static void RegisterAsTeam(teams t)
        {
            try
            {
                foreach (string p in t.participants)
                {
                    string query = "INSERT INTO event_participants (event_id, participant_id) SELECT (SELECT event_id FROM itec_events WHERE event_name = '{0}'), (SELECT participant_id FROM participants WHERE name = '{1}')";
                    query = string.Format(query, t.eventn, p);
                    SqlHelper.executeDML(query);

                    string sql = "INSERT INTO team_participants (team_id, participant_id) SELECT (SELECT team_id FROM teams WHERE team_name = '{0}'), (SELECT participant_id FROM participants WHERE name = '{1}')";
                    sql = string.Format(sql, t.team_name, p);
                    SqlHelper.executeDML(sql);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error registering team: " + ex.Message);
            }
        }

        public static void AddFee(string feestatus, float amount, string name)
        {
            try
            {
                string query = "UPDATE event_participants\r\nSET payment_status_id = (\r\n    SELECT lookup_id\r\n    FROM lookup\r\n    WHERE value = '{0}' AND category = 'PaymentStatus'\r\n),\r\nfee_amount = {1}\r\nWHERE participant_id IN (\r\n    SELECT participant_id\r\n    FROM participants\r\n    WHERE name = '{2}'\r\n);";
                query = string.Format(query, feestatus, amount, name);
                SqlHelper.executeDML(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding fee: " + ex.Message);
            }
        }
    }
}
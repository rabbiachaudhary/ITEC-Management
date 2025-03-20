using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using sqlhelper;

namespace dbmid_project.DL
{
    internal class RegisterParticipantDL
    {

        public static void Register(RegisterPartcipantsBL b)
        {

            string exist = "SELECT Count(*) From event_participants where event_id=(select event_id from itec_events where event_name='{0}') and participant_id =(select participant_id from participants where name='{1}')";
            exist = string.Format(exist,b.eventn,b.participant);
            int count = SqlHelper.CountRows(exist);
            if (count > 0)
            {
                MessageBox.Show("This Participant has already registered in this event");
            }

            else
            {
                string query = "INSERT INTO event_participants (event_id,participant_id,payment_status_id,fee_amount) SELECT (select event_id from itec_events where event_name='{0}'),(select participant_id from participants where name='{1}'), (select lookup_id from lookup where value='{2}'), {3}";
                query = string.Format(query, b.eventn, b.participant, b.status, b.fees);
                SqlHelper.executeDML(query);
                MessageBox.Show("Participant Registered To Event Successfully");
            }
        }


    }
}

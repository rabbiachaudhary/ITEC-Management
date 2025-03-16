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
            string query = "INSERT INTO event_participants (event_id,participant_id,payment_status_id,fee_amount) SELECT (select event_id from itec_events where event_name='{0}'),(select participant_id from participants where name='{1}'), (select lookup_id from lookup where value='{2}'), {3}";
            query = string.Format(query, b.eventn,b.participant , b.status, b.fees);
            SqlHelper.executeDML(query);
            MessageBox.Show("Participant Registered To Event Successfully");
        }


    }
}

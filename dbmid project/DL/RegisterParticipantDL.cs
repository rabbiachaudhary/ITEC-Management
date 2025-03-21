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
            int year = ITECedi.GetItec_Year();

            string exist = "SELECT Count(*) From event_participants where event_id=(select event_id from itec_events where event_name='{0}') and participant_id =(select participant_id from participants where name='{1}')";
            exist = string.Format(exist,b.eventn,b.participant);
            int count = SqlHelper.CountRows(exist);
            if (count > 0)
            {
                MessageBox.Show("This Participant has already registered in this event");
            }

            else
            {
                string query = "INSERT INTO event_participants (event_id,participant_id,payment_status_id,fee_amount) SELECT (select event_id from itec_events where event_name='{0}'),(select participant_id from participants where name='{1}'), (select lookup_id from lookup where value='{2}' and category ='PaymentStatus'), {3}";
                query = string.Format(query, b.participant, b.eventn, b.status, b.fees);
                MessageBox.Show(query);
                SqlHelper.executeDML(query);


                string finance = "INSERT INTO finances (itec_id, event_id, type_id, amount, from_entity_type, from_entity_id, to_entity_type, to_entity_id, description, date_recorded) " +
                  "VALUES ( " +
                  "(SELECT itec_id FROM itec_editions WHERE year = {0}), " +
                  "(SELECT event_id FROM itec_events WHERE event_name = '{1}'), " +
                  "(SELECT lookup_id FROM lookup WHERE category = 'FinanceTypes' AND value = 'Ticket Sales'), " +
                  "{2}, " +
                  "'User', " +
                  "(SELECT participant_id FROM participants WHERE name = '{3}'), " +
                  "'Committee', " +
                  "(SELECT committee_id FROM itec_events WHERE event_name = '{4}'), " +
                  "'Registration fees for event {1}', " +
                  "NOW())";
                finance = string.Format(finance, year, b.participant, b.fees, b.eventn, b.participant);
                MessageBox.Show(finance);
                SqlHelper.executeDML(finance);
                
                MessageBox.Show("Participant Registered To Event Successfully");
            }
        }


    }
}

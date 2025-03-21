using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using sqlhelper;

namespace dbmid_project.DL
{
    internal class TransactionsDL
    {
        public static void AddTransaction(TransactionsBL b)
        {
            int year = ITECedi.GetItec_Year();

            string query = "INSERT INTO finances ( itec_id,     event_id,     type_id,    amount,    from_entity_type,     from_entity_id,     to_entity_type,   to_entity_id,     description,   date_recorded) " +
                "VALUES (" +
                "(SELECT itec_id FROM itec_editions WHERE year = {0}), " +
                " (SELECT event_id FROM itec_events WHERE event_name = '{1}')," +
                "(SELECT lookup_id FROM lookup WHERE category = 'FinanceTypes' AND value = '{2}'),{3},   '{4}'," +
                "   CASE WHEN '{4}' = 'User' THEN (SELECT user_id FROM users WHERE username = '{5}') " +
                "       WHEN '{4}' = 'Sponsor' THEN (SELECT sponsor_id FROM sponsors WHERE sponsor_name = '{5}') " +
                "        WHEN '{4}' = 'Committee' THEN (SELECT committee_id FROM committees WHERE committee_name = '{5}') " +
                "        WHEN '{4}' = 'Vendor' THEN (SELECT vendor_id FROM vendors WHERE vendor_name = '{5}')                 ELSE NULL END,'{6}', " +
                "   CASE " +
                " WHEN '{6}' = 'User' THEN (SELECT user_id FROM users WHERE username = '{7}') " +
                "        WHEN '{6}' = 'Sponsor' THEN (SELECT sponsor_id FROM sponsors WHERE sponsor_name = '{7}') " +
                "        WHEN '{6}' = 'Committee' THEN (SELECT committee_id FROM committees WHERE committee_name = '{7}') " +
                "        WHEN '{6}' = 'Vendor' THEN (SELECT vendor_id FROM vendors WHERE vendor_name = '{7}') " +
                "        ELSE NULL     END,     '{8}',     '{9}')";

            query = string.Format(query, year, b.eventn, b.FinanceType, b.amount, b.stype,b.sname, b.rtype, b.rname, b.description, b.date);
            
            MessageBox.Show(query);
            
            SqlHelper.executeDML(query);
            MessageBox.Show("Transaction added successfully");
        }
    }
}

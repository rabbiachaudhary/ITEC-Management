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

            string query = "INSERT INTO finances (itec_id , event_id, type_id, amount, from_entity_type, from_entity_id, to_entity_type, to_entity_id, description, date_recorded)" +
                " VALUES ((select itec_id from itec_editions where year={0}) , (select event_id from itec_events where event_name='{1}'), (select lookup_id from lookup where category='FinanceType' and value='{2}')" +
                "  ,{3}, '{4}'  ," +
                " ( CASE when from_entity_type='User' THEN (Select user_id from users where username='{5}')   when from_entity_type='Sponsor' THEN (select sponsor_id form sponsors where sponsor_name='{5}')  " +
                "  when from_entity_type='Committee' then (select committee_id from committees where committee_name='{5}')    when from_entity_type='Vendor' then (select vendor_id from vendors where vendor_name='{5}')" +
                ")," +
                "'{6}',(CASE when to_entity_type='User' THEN (Select user_id from users where username='{7}')     when to_entity_type='Sponsor' THEN (select sponsor_id form sponsors where sponsor_name='{7}')" +
                "    when to_entity_type='Committee' then (select committee_id from committees where committee_name='{7}')     when to_entity_type='Vendor' then (select vendor_id from vendors where vendor_name='{7}')) ," +
                "'{8}', '{9}' )";
            query = string.Format(query, year, b.eventn, b.FinanceType, b.amount, b.stype,b.sname, b.rtype, b.rname, b.rname, b.description, b.date);
            SqlHelper.executeDML(query);
            MessageBox.Show("Transaction added successfully");
        }
    }
}

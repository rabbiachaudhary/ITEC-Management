using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbmid_project.BL;
using sqlhelper;

namespace dbmid_project.DL
{
    internal class DutiesDL
    {
        public static void AddDuties(DutiesBL d)
        {

            string query = "INSERT INTO duties (committee_id,assigned_to,task_description,deadline, status_id) VALUES ( (select committee_id from committees where committee_name='{0}'),'{1}','{2}' ,'{3}',(select lookup_id from lookup where value='{4}' AND category='DutyStatus') )";
            query = string.Format(query, d.committee, d.member,d.taskdesc, d.date,d.status);
            SqlHelper.executeDML(query);
            MessageBox.Show("Duty Assigned successfully");
        }
    }
}

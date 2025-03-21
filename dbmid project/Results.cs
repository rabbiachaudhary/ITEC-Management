using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlhelper;

namespace dbmid_project
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
            LoadDataInListView();
        }


        private void LoadDataInListView()
        {
            int year = ITECedi.GetItec_Year();

            string query = "select event_name, name ,position ,score , remarks from event_results r" +
                " join itec_events e on e.event_id=r.event_id " +
                " join itec_editions ie on ie.itec_id=e.itec_id " +
                "join participants p on r.participant_id=p.participant_id " +
                "where year={0} ";
            query = string.Format(query, year);
            DataTable dt = SqlHelper.getDataTable(query);
            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["event_name"].ToString());

                item.SubItems.Add(row["name"].ToString());

                item.SubItems.Add(row["position"].ToString());
                item.SubItems.Add(row["score"].ToString());
                item.SubItems.Add(row["remarks"].ToString());

                listView1.Items.Add(item);

            }
        }
    }
}

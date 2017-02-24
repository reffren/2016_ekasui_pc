using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASUIdesc
{
    class FillListPPRForMonth
    {
        ListViewItem listitem;
        SqlConnection con;
        SqlDataAdapter ada;
        DataTable dt;
        DataRow dr;
        private ListView listView;
        private string _sqlPPRForMonth;
        private string _quantityMonthPPR;
        private string _normaVremMonthForPlan;

        public FillListPPRForMonth(ListView listView1, string sqlPPRForMonth, string quantityMonthPPR, string normaVremMonthForPlan)
        {
            // TODO: Complete member initialization
            this._normaVremMonthForPlan = normaVremMonthForPlan;
            this.listView = listView1;
            this._sqlPPRForMonth = sqlPPRForMonth;
            this._quantityMonthPPR = quantityMonthPPR;
            FillListForMonth();
        }

        public void FillListForMonth()
        {
            listView.View = View.Details;
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\tim\documents\visual studio 2013\Projects\ASUIdesc\ASUIdesc\Database.mdf;Integrated Security=True");
            ada = new SqlDataAdapter(_sqlPPRForMonth, con);
            dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int doNotGiveId = 0;
                dr = dt.Rows[i];

                listitem = new ListViewItem(dr["number"].ToString());

                if (dr[_normaVremMonthForPlan].ToString() == "")
                {
                    doNotGiveId = 1;
                    listitem.BackColor = Color.SandyBrown;
                }
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["klass_uchastka"].ToString());
                listitem.SubItems.Add(dr[_quantityMonthPPR].ToString());
                listitem.SubItems.Add(dr["norma_vremeni"].ToString());
                listitem.SubItems.Add(dr["obosn_norm_vrem"].ToString());
                listitem.SubItems.Add(dr[_normaVremMonthForPlan].ToString());
                //listitem.SubItems.Add(dr["work_end_quantity"].ToString());
                //  listitem.SubItems.Add(dr["work_end_fact"].ToString());
                // listitem.SubItems.Add(dr["work_end_note"].ToString());
                // listitem.SubItems.Add(dr["work_end_time"].ToString());
                if (doNotGiveId != 1)
                    listitem.SubItems.Add(dr["id"].ToString()); // чтобы осмотры, тек. ремонты итд не были кликабельны
                listView.Items.Add(listitem);
            }
        }
    }
}

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
    class FillListPPR
    {
        ListViewItem listitem;
        SqlConnection con;
        SqlDataAdapter ada;
        DataTable dt;
        DataRow dr;
        private ListView listView;
        private string _sqlPPR;

        public FillListPPR(ListView listView2, string sqlPPR)
        {
            // TODO: Complete member initialization
            this.listView = listView2;
            this._sqlPPR = sqlPPR;
            FillListForPPR();
        }

        public void FillListForPPR()
        {
            listView.View = View.Details;
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\tim\documents\visual studio 2013\Projects\ASUIdesc\ASUIdesc\Database.mdf;Integrated Security=True");
            ada = new SqlDataAdapter(_sqlPPR, con);
            dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                 dr = dt.Rows[i];


                listitem = new ListViewItem(dr["number"].ToString());
                int s=dr["name_of_place"].ToString().CompareTo("1"); // if not equal == -1, equal ==1
                if (s==1)
                {
                    listitem.BackColor = Color.SandyBrown;
                }
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["name_of_place"].ToString());
                listitem.SubItems.Add(dr["klass_uchastka"].ToString());
                listitem.SubItems.Add(dr["izmeritel"].ToString());
                listitem.SubItems.Add(dr["kol_izm"].ToString());
                listitem.SubItems.Add(dr["year"].ToString());
                listitem.SubItems.Add(dr["2761p"].ToString());
                listitem.SubItems.Add(dr["fact"].ToString());
                listitem.SubItems.Add(dr["data_vipoln"].ToString());
                listitem.SubItems.Add(dr["norma_vremeni"].ToString());
                listitem.SubItems.Add(dr["obosn_norm_vrem"].ToString());
                listitem.SubItems.Add(dr["podrazdelenie"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_year"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_year"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_year"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_year"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_year"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_january"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_january"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_january"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_january"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_january"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_february"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_february"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_february"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_february"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_february"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_march"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_march"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_march"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_march"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_march"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_april"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_april"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_april"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_april"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_april"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_may"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_may"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_may"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_may"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_may"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_june"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_june"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_june"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_june"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_june"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_july"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_july"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_july"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_july"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_july"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_august"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_august"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_august"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_august"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_august"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_september"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_september"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_september"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_september"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_september"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_october"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_october"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_october"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_october"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_october"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_november"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_november"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_november"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_november"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_november"].ToString());
                listitem.SubItems.Add(dr["quantity_plan_december"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_plan_december"].ToString());
                listitem.SubItems.Add(dr["quantity_fact_december"].ToString());
                listitem.SubItems.Add(dr["vrem_na_fact_obem_december"].ToString());
                listitem.SubItems.Add(dr["norma_vrem_fact_december"].ToString());
                listView.Items.Add(listitem);
            }
        }
    }

}
    



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASUIdesc
{
    public partial class Form1 : Form
    {
        FillDatabase filldb;
        FillListPPR fillList;
        FillListPPRForMonth fillListMonth;
        QueryCurrentDate queryCurDate;
        string quantityMonthPPR;
        string normaVremMonthForPlan;
        int anchor = 0;
        string path;
        string id;
        string sqlPPR = "select * from ppr where name is not null";
        //"select * from ppr where norma_vrem_plan_january is not null UNION select * from ppr where name_of_place='1' order by id"; // for testing queries

        string sqlQueryPPRForMonth;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yy HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yy HH:mm";
            fillLists();
        }


        public void fillLists()
        {
            if (anchor == 0)
            {
                fillList = new FillListPPR(listView2, sqlPPR); // запуск только один раз, чтобы не было дублей
                queryCurDate = new QueryCurrentDate();
                quantityMonthPPR = queryCurDate.getQuantityMonthPPRCurDate();
                normaVremMonthForPlan = queryCurDate.getNormaVremMonthForPlan();
                comboBoxMonth.SelectedIndex = queryCurDate.IndexMonth();
            }
            sqlQueryPPRForMonth = "select id, number, name, klass_uchastka, " + quantityMonthPPR + ", norma_vremeni, obosn_norm_vrem, " + normaVremMonthForPlan + " from ppr where " + normaVremMonthForPlan + " is not NULL UNION select id, number, name, klass_uchastka, " + quantityMonthPPR + ", norma_vremeni, obosn_norm_vrem, " + normaVremMonthForPlan + " from ppr where name_of_place='1' order by id";
            fillListMonth = new FillListPPRForMonth(listView1, sqlQueryPPRForMonth, quantityMonthPPR, normaVremMonthForPlan);
        }
        private void openFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"C:\";
            openFile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;
                filldb = new FillDatabase();
                filldb.FillData(path);
                anchor = 0;
                fillLists();

            }
        }

        private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e) // создаем таблицу в инцидентах
        {
            if (e.Column == 1)
                e.Graphics.DrawLine(Pens.Silver, e.CellBounds.Location, new Point(e.CellBounds.Left, e.CellBounds.Bottom));
            if (e.Row == 1)
                e.Graphics.DrawLine(Pens.Silver, e.CellBounds.Location, new Point(e.CellBounds.Right, e.CellBounds.Top));
            if (e.Row == 3)
                e.Graphics.DrawLine(Pens.Silver, e.CellBounds.Location, new Point(e.CellBounds.Right, e.CellBounds.Top));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // FormForFillData formFill = new FormForFillData();
            // formFill.Show();
        }


        private void btnChooseItemMonthPPR_Click(object sender, EventArgs e)
        {
            try
            {
                id = listView1.SelectedItems[0].SubItems[7].Text; //SubItems - строка выгрузки по счету в классе FillListPPRForMonth, т.е. мы получаем id БД
                FormForFillData formFill = new FormForFillData(id);
                formFill.Show();
            }
            catch
            {
                MessageBox.Show("Пожалуйста выберите требуемую работу!", "Ошибка");
            }
        }

        private void listView2_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // colums is not edited
            //e.Cancel = true;
            // e.NewWidth = listView2.Columns[e.ColumnIndex].Width;
        }

        private void btnDownloadPPR_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void btnExportMonthPPR_Click(object sender, EventArgs e)
        {
            ExportToExcel export = new ExportToExcel();
            export.ExportExcel(listView1);
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Январь"))
            {
                quantityMonthPPR = "quantity_plan_january";
                normaVremMonthForPlan = "norma_vrem_plan_january";
            }
            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Февраль"))
            {
                quantityMonthPPR = "quantity_plan_february";
                normaVremMonthForPlan = "norma_vrem_plan_february";
            }
            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Март"))
            {
                quantityMonthPPR = "quantity_plan_march";
                normaVremMonthForPlan = "norma_vrem_plan_march";
            }
            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Апрель"))
            {
                quantityMonthPPR = "quantity_plan_april";
                normaVremMonthForPlan = "norma_vrem_plan_april";
            }
            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Май"))
            {
                quantityMonthPPR = "quantity_plan_may";
                normaVremMonthForPlan = "norma_vrem_plan_may";
            }
            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Июнь"))
            {
                quantityMonthPPR = "quantity_plan_june";
                normaVremMonthForPlan = "norma_vrem_plan_june";
            }
            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Июль"))
            {
                quantityMonthPPR = "quantity_plan_july";
                normaVremMonthForPlan = "norma_vrem_plan_july";
            }

            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Август"))
            {
                quantityMonthPPR = "quantity_plan_august";
                normaVremMonthForPlan = "norma_vrem_plan_august";
            }
            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Сентябрь"))
            {
                quantityMonthPPR = "quantity_plan_september";
                normaVremMonthForPlan = "norma_vrem_plan_september";
            }
            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Октябрь"))
            {
                quantityMonthPPR = "quantity_plan_october";
                normaVremMonthForPlan = "norma_vrem_plan_october";
            }
            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Ноябрь"))
            {
                quantityMonthPPR = "quantity_plan_november";
                normaVremMonthForPlan = "norma_vrem_plan_november";
            }
            if (comboBoxMonth.SelectedIndex == comboBoxMonth.FindStringExact("Декабрь"))
            {
                quantityMonthPPR = "quantity_plan_december";
                normaVremMonthForPlan = "norma_vrem_plan_december";
            }
            sqlQueryPPRForMonth = "select id, number, name, klass_uchastka, " + quantityMonthPPR + ", norma_vremeni, obosn_norm_vrem, " + normaVremMonthForPlan + " from ppr where " + normaVremMonthForPlan + " is not NULL UNION select id, number, name, klass_uchastka, " + quantityMonthPPR + ", norma_vremeni, obosn_norm_vrem, " + normaVremMonthForPlan + " from ppr where name_of_place='1' order by id";
            listView1.Items.Clear();
            anchor = 1;
            fillLists();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.ppr". При необходимости она может быть перемещена или удалена.
            this.pprTableAdapter.Fill(this.databaseDataSet.ppr);

        }
    }
}


    
        


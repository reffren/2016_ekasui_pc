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
    public partial class FormForFillData : Form
    {
        private string id;
        int duration = 0;

        Label namelabel;

       // public FormForFillData()
       // {
      //      InitializeComponent();
      //  }

        public FormForFillData(string id)
        {
            // TODO: Complete member initialization
            this.id = id;
            InitializeComponent();
        }

        private void FormForFillData_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           tableLayoutPanel1.Visible = false;
           //tableLayoutPanel1.Location = new Point(-1000, -1000);
           namelabel = new Label();
           namelabel.AutoSize = true;
           namelabel.BringToFront();
           namelabel.Location = new Point(100, 100);
           namelabel.Font = new Font(namelabel.Font.FontFamily, 70);
           this.Controls.Add(namelabel);
           timer1.Interval = 1000;
           timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration++;
            namelabel.Text = duration.ToString();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketForm.BLL;

namespace TicketForm
{
    public partial class frm_sell : Form
    {
        public frm_sell()
        {
            InitializeComponent();
        }
        MyFun mf = new MyFun();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Manger mainForm = new frm_Manger();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = System.DateTime.Now.ToLongDateString();
            dataGridView1.DataSource = mf.GetOne1(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mf.GetAll("total");
        }

        private void frm_sell_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mf.GetAll("total");
        }
    }
}

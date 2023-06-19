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
    public partial class frm_user_h : Form
    {
        public frm_user_h()
        {
            InitializeComponent();
        }
        MyFun ms = new MyFun();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Manger mainForm = new frm_Manger();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void frm_user_h_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ms.GetAll("user_info");
        }
    }
}

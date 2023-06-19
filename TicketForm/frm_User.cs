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
    public partial class frm_User : Form
    {
        public string sendValue;
        public frm_User(string str)
        {
            InitializeComponent();
            sendValue = str;
        }
        MyFun mf = new MyFun();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定要退出吗！！", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form1 mainForm = new Form1();
                mainForm.StartPosition = FormStartPosition.CenterScreen;
                mainForm.Show();
            }
        }

        private void frm_User_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mf.GetAll("ticket");
            label5.Text = mf.GetOneSure("user_info","账号",sendValue).DataSet.Tables[0].Rows[0]["财富"].ToString();
            label2.Text = mf.GetOneSure("user_info", "账号", sendValue).DataSet.Tables[0].Rows[0]["昵称"].ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_money mainForm = new frm_money(sendValue);
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_buy mainForm = new frm_buy(sendValue);
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

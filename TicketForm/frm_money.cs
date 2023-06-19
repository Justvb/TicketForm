using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketForm.BLL;
using TicketForm.Models;

namespace TicketForm
{
    public partial class frm_money : Form
    {
        public string sendvalue;
        public frm_money(string str)
        {
            InitializeComponent();
            sendvalue = str;
        }
        MyFun mf = new MyFun();
        private void button1_Click(object sender, EventArgs e)
        {
            string money = textBox1.Text;
            MyStr stu = new MyStr { MIno = sendvalue, MImoney = money };
            bool result = mf.UpdateMoney(stu);
            if (result)
            {
                MessageBox.Show("充值成功");
            }
            else
            {
                MessageBox.Show("充值失败");
            }

        }

        private void frm_money_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“database1DataSet.user_total”中。您可以根据需要移动或删除它。
            this.user_totalTableAdapter.Fill(this.database1DataSet.user_total);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_User mainForm = new frm_User(sendvalue);
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
           

        }

        private void 查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.user_totalTableAdapter.查询(this.database1DataSet.user_total);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

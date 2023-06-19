using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketForm.DAL;
using TicketForm.Models;

namespace TicketForm
{
    public partial class frm_issue : Form
    {

        public frm_issue()
        {
            InitializeComponent();

        }
        MySql mq = new MySql();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Manger mainForm = new frm_Manger();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void frm_issue_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mq.GetAll("ticket");
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string strprice = "未开奖";
            string strtime=System.DateTime.Now.ToLongDateString();
            MyStr stu = new MyStr { MTprice = strprice,MTtime=strtime };
            bool result = mq.Addticket(stu);
            if (result)
            {
                MessageBox.Show("发布成功！！");
                dataGridView1.DataSource = mq.GetAll("ticket");
            }
            else
            {
                MessageBox.Show("发布失败");
            }
        }

       

    }
}

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
using TicketForm.DAL;
using TicketForm.Models;

namespace TicketForm
{
    public partial class frm_issue_rem : Form
    {
        public string str;
        public int n;
        public frm_issue_rem()
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
            dataGridView1.DataSource = mf.GetOne(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mf.GetAll("ticket");
        }

        private void frm_issue_rem_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mf.GetAll("ticket");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyStr st = new MyStr { MTno = n };
            bool result = mf.Delete(st);
            if (result)
            {
                MessageBox.Show("删除成功");
                dataGridView1.DataSource = mf.GetAll("ticket");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)		//用于判断是否选中了DataGridView中的一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            n = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            dataGridView1.DataSource = mf.GetOneSure1("ticket", "编号", n);
        }
    }
}

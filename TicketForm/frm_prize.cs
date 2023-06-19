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
using TicketForm.Models;

namespace TicketForm
{
    public partial class frm_prize : Form
    {
        public frm_prize()
        {
            InitializeComponent();
        }
        MyFun mf = new MyFun();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Manger mainForm = new frm_Manger();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入编号！！！");
                return;
            }
            string a = mf.GetOneSure1("ticket", "编号", int.Parse(textBox1.Text)).DataSet.Tables[0].Rows[0]["中奖号码"].ToString();
            if (a == "未开奖")
            {
                int Fno = int.Parse(textBox1.Text);
                string strprice = string.Join(",", GetRandomArray(7, 1, 33));
                MyStr stu = new MyStr { MTno = Fno, MTprice = strprice };
                bool result = mf.UpdatePrice(stu);
                if (result)
                {
                    MessageBox.Show("第" + Fno + "已开奖");
                    dataGridView1.DataSource = mf.GetAll("ticket");
                }
                else
                {
                    MessageBox.Show("开奖失败");
                }
            }
            else
            {
                MessageBox.Show("已开奖，不需再开奖了");
            }

            

        }

        public int[] GetRandomArray(int Number, int minNum, int maxNum)
        {

            int j;
            int[] b = new int[Number];
            Random r = new Random();
            for (j = 0; j < Number; j++)
            {
                int i = r.Next(minNum, maxNum + 1);
                int num = 0;
                for (int k = 0; k < j; k++)
                {
                    if (b[k] == i)
                    {
                        num = num + 1;
                    }
                }
                if (num == 0)
                {
                    b[j] = i;
                }
                else
                {
                    j = j - 1;
                }
            }

            return b;
        }

        private void frm_prize_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mf.GetAll("ticket");
            dataGridView2.DataSource = mf.GetAll("total");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)		//用于判断是否选中了DataGridView中的一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("请选择编号");
                return;
            }
            string price = mf.GetOneSure("ticket", "编号", textBox1.Text).DataSet.Tables[0].Rows[0]["中奖号码"].ToString();
            try
            {
                string price2 = mf.GetOnePrice("total", "编号", textBox1.Text).DataSet.Tables[0].Rows[0]["购买号码"].ToString();
                if (price == price2)
                {
                    string userno = mf.GetOnePrice("total", "编号", textBox1.Text).DataSet.Tables[0].Rows[0]["账号"].ToString();

                    MyStr stu = new MyStr { MIno = userno, MIprice=price};
                    bool result = mf.UpdatePrice1(stu);
                    if (result)
                    {
                        dataGridView2.DataSource = mf.GetOneSure("user_info", "账号", userno);
                    }
                    else
                    {
                        MessageBox.Show("查看失败");
                    }
                    
                }
                else
                {
                    
                }
            }
            catch
            {
                MessageBox.Show("无人中奖");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请选择编号");
                return;
            }
            
            string price=mf.GetOneSure1("ticket", "编号", int.Parse(textBox1.Text)).DataSet.Tables[0].Rows[0]["中奖号码"].ToString();
            try{
                string price2 = mf.GetOnePrice("total", "编号", textBox1.Text).DataSet.Tables[0].Rows[0]["购买号码"].ToString();
                if (price == price2)
                {
                    string userno= mf.GetOnePrice("total", "编号", textBox1.Text).DataSet.Tables[0].Rows[0]["账号"].ToString();
                    int mymoney = int.Parse(mf.GetOneSure("user_info", "账号", userno).DataSet.Tables[0].Rows[0]["财富"].ToString());
                    mymoney = mymoney+1000000;
                    MyStr stu = new MyStr { MIno = userno, MImoney = mymoney.ToString() };
                    bool result = mf.UpdateMoney(stu);
                    if (result)
                    {
                        MessageBox.Show("有人中奖");
                    }
                    else
                    {
                        MessageBox.Show("兑奖失败");
                    }
                }
                else
                {
                    MessageBox.Show("兑奖成功");
                }
            }
            catch
            {
                MessageBox.Show("无人中奖");
            }
            
            
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butto52_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mf.GetAll("ticket");
            dataGridView2.DataSource = mf.GetAll("total");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

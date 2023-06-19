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
    public partial class frm_buy : Form
    {
        public string sendValue;
        public frm_buy(string str)
        {
            InitializeComponent();
            sendValue = str;
        }
        MyFun mf = new MyFun();
        Verification ver = new Verification();
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""|| textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""
                || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("号码不能为空");
                return;
            }
            if (!ver.IsNumber(textBox1.Text)|| !ver.IsNumber(textBox2.Text) || !ver.IsNumber(textBox3.Text)
                || !ver.IsNumber(textBox4.Text)
                || !ver.IsNumber(textBox5.Text) || !ver.IsNumber(textBox6.Text) || !ver.IsNumber(textBox7.Text))
            {
                MessageBox.Show("号码只能为33以内数字哦！！");
                return;
            }

            try
            {
                Money();
                int n1 = int.Parse(textBox1.Text);
                int n2 = int.Parse(textBox2.Text);
                int n3 = int.Parse(textBox3.Text);
                int n4 = int.Parse(textBox4.Text);
                int n5 = int.Parse(textBox5.Text);
                int n6 = int.Parse(textBox6.Text);
                int n7 = int.Parse(textBox7.Text);
                int[] types = new int[] { n1, n2, n3, n4, n5, n6, n7 };
                string price = string.Join(",", types);
                string Fname = mf.GetOneSure("user_info", "账号", sendValue).DataSet.Tables[0].Rows[0]["昵称"].ToString();
                string Fbh = mf.GetOneSure1("ticket", "编号", int.Parse(textBox8.Text)).DataSet.Tables[0].Rows[0]["编号"].ToString();
                string Ftime = System.DateTime.Now.ToLongDateString();
                MyStr stu = new MyStr { MTObh = Fbh, MTOno = sendValue, MTOname = Fname, MTOprice = price, MTOtime = Ftime };

                bool result = mf.Buyticket(stu);
                if (result)
                {
                    MessageBox.Show("购买成功");
                    dataGridView1.DataSource = mf.GetOneSure("total", "账号", sendValue);
                }
                else
                {
                    MessageBox.Show("购买失败！");
                }
            }
            catch
            {
                MessageBox.Show("没有找到彩票信息！！");
            }

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_User mainForm = new frm_User(sendValue);
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void frm_buy_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = mf.GetAll("ticket");
            dataGridView1.DataSource = mf.GetOneSure("total", "账号", sendValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("请选择一期彩票！！");
                return;
            }
            string strprice = string.Join(",", GetRandomArray(7, 1, 33));
           
            string Fname = mf.GetOneSure("user_info", "账号", sendValue).DataSet.Tables[0].Rows[0]["昵称"].ToString();
            try
            {
                Money();
                string Fbh = mf.GetOneSure1("ticket", "编号", int.Parse(textBox8.Text)).DataSet.Tables[0].Rows[0]["编号"].ToString();
                string Ftime = System.DateTime.Now.ToLongDateString();
                MyStr stu = new MyStr { MTObh = Fbh, MTOno = sendValue, MTOname = Fname, MTOprice = strprice, MTOtime = Ftime };

                bool result = mf.Buyticket(stu);
                if (result)
                {
                    MessageBox.Show("购买成功");
                    dataGridView1.DataSource = mf.GetOneSure("total", "账号", sendValue);
                }
                else
                {
                    MessageBox.Show("购买失败！");
                }
            }
            catch
            {
                MessageBox.Show("没有找到彩票信息！！");
            }


            
            

        }

        public void Money()
        {
            int mymoney = int.Parse(mf.GetOneSure("user_info", "账号", sendValue).DataSet.Tables[0].Rows[0]["财富"].ToString());
            if (mymoney <= 0)
            {
                MessageBox.Show("对不起余额不足，请充值！！！");
            }
            mymoney = mymoney - 5;

            MyStr stu = new MyStr { MIno = sendValue, MImoney = mymoney.ToString() };
            bool result = mf.UpdateMoney(stu);
            if (result)
            {
                
            }
            else
            {
                
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
    }
}

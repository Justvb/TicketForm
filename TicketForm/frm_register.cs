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
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }
        MyFun mf = new MyFun();
        Verification ver = new Verification();
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mainForm = new Form1();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string count = txt_count.Text;
            string pwd = txt_pwd.Text;
            string nc = txt_name.Text;
            string rePwd = txt_submit.Text;
            if (count == "" || pwd == "" || nc == "" || rePwd == "")
            {
                MessageBox.Show("请输入完整信息！！！");
                return;
            }
            if (!ver.IsCode(txt_count.Text))//验证账号是否正确
            {
                MessageBox.Show("请输入4位数字账号！！！");
                return;
            }

            if (!ver.IsChinese(txt_name.Text))//验证账号是否正确
            {
                MessageBox.Show("请输入中文昵称！！！");
                return;
            }

            if (pwd == rePwd)
            {
                MyStr user = new MyStr { account = count, name = nc, password = pwd };
                bool result = mf.Register(user);

                if (result)
                {
                    MessageBox.Show("注册成功！！！");
                }
                else
                {
                    MessageBox.Show("账号已存在！！！");
                }
            }
            else
            {
                MessageBox.Show("两次输入不一致！！！");
            }
        }

        private void frm_register_Load(object sender, EventArgs e)
        {
            txt_pwd.PasswordChar = '*';
            txt_submit.PasswordChar = '*';
        }
    }
}

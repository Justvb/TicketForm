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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySql mq = new MySql();
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_register mainForm = new frm_register();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (rdo_student.Checked)
            {
                if (txt_number.Text == "" || txt_password.Text == "")
                {
                    MessageBox.Show("请输入完整信息！！！");
                    return;
                }
                string count = txt_number.Text;
                string pwd = txt_password.Text;
                MyStr user = new MyStr { account = count, password = pwd };
                bool result = mq.Login(user);
                if (result)
                {
                    this.Hide();
                    frm_User mainForm = new frm_User(txt_number.Text);
                    mainForm.StartPosition = FormStartPosition.CenterScreen;
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("账号或密码错误！！！");
                }
                return;
            }

            if (rdo_teacher.Checked)
            {
                if (txt_number.Text.Trim() == "" || txt_password.Text.Trim() == "")
                    MessageBox.Show("用户名或密码为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (txt_number.Text == "123" && txt_password.Text == "123")
                    {
                        this.Hide();
                        frm_Manger mainForm = new frm_Manger();
                        mainForm.StartPosition = FormStartPosition.CenterScreen;
                        mainForm.Show();
                    }
                }
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';

        }

       
        
    }
}

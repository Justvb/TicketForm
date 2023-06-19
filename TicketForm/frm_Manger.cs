using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketForm
{
    public partial class frm_Manger : Form
    {
 
        public frm_Manger()
        {
            InitializeComponent();
      
        }

        private void frm_Manger_Load(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 发行彩票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_issue mainForm = new frm_issue();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void 查看发行记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_issue_rem mainForm = new frm_issue_rem();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void 销售情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_sell mainForm = new frm_sell();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void 用户信息查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 公证开奖ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_prize mainForm = new frm_prize();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void 用户余额ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_user_h mainForm = new frm_user_h();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }
    }
}

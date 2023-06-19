namespace TicketForm
{
    partial class frm_Manger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.彩票管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发行彩票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看发行记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户余额ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公证开奖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.彩票管理ToolStripMenuItem,
            this.公证开奖ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 彩票管理ToolStripMenuItem
            // 
            this.彩票管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发行彩票ToolStripMenuItem,
            this.查看发行记录ToolStripMenuItem,
            this.销售情况ToolStripMenuItem,
            this.用户余额ToolStripMenuItem});
            this.彩票管理ToolStripMenuItem.Name = "彩票管理ToolStripMenuItem";
            this.彩票管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.彩票管理ToolStripMenuItem.Text = "彩票管理";
            // 
            // 发行彩票ToolStripMenuItem
            // 
            this.发行彩票ToolStripMenuItem.Name = "发行彩票ToolStripMenuItem";
            this.发行彩票ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.发行彩票ToolStripMenuItem.Text = "发行彩票";
            this.发行彩票ToolStripMenuItem.Click += new System.EventHandler(this.发行彩票ToolStripMenuItem_Click);
            // 
            // 查看发行记录ToolStripMenuItem
            // 
            this.查看发行记录ToolStripMenuItem.Name = "查看发行记录ToolStripMenuItem";
            this.查看发行记录ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查看发行记录ToolStripMenuItem.Text = "发行记录";
            this.查看发行记录ToolStripMenuItem.Click += new System.EventHandler(this.查看发行记录ToolStripMenuItem_Click);
            // 
            // 销售情况ToolStripMenuItem
            // 
            this.销售情况ToolStripMenuItem.Name = "销售情况ToolStripMenuItem";
            this.销售情况ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.销售情况ToolStripMenuItem.Text = "销售情况";
            this.销售情况ToolStripMenuItem.Click += new System.EventHandler(this.销售情况ToolStripMenuItem_Click);
            // 
            // 用户余额ToolStripMenuItem
            // 
            this.用户余额ToolStripMenuItem.Name = "用户余额ToolStripMenuItem";
            this.用户余额ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.用户余额ToolStripMenuItem.Text = "用户余额";
            this.用户余额ToolStripMenuItem.Click += new System.EventHandler(this.用户余额ToolStripMenuItem_Click);
            // 
            // 公证开奖ToolStripMenuItem
            // 
            this.公证开奖ToolStripMenuItem.Name = "公证开奖ToolStripMenuItem";
            this.公证开奖ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.公证开奖ToolStripMenuItem.Text = "公证开奖";
            this.公证开奖ToolStripMenuItem.Click += new System.EventHandler(this.公证开奖ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // frm_Manger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_Manger";
            this.Text = "管理员主页";
            this.Load += new System.EventHandler(this.frm_Manger_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 彩票管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发行彩票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看发行记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公证开奖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户余额ToolStripMenuItem;
    }
}
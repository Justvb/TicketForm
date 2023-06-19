namespace TicketForm
{
    partial class frm_money
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new TicketForm.Database1DataSet();
            this.usertotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_totalTableAdapter = new TicketForm.Database1DataSetTableAdapters.user_totalTableAdapter();
            this.账号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.昵称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.财富DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.中奖号码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.流水号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.查询ToolStrip = new System.Windows.Forms.ToolStrip();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertotalBindingSource)).BeginInit();
            this.查询ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "充值";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 360);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "金额：";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.账号DataGridViewTextBoxColumn,
            this.昵称DataGridViewTextBoxColumn,
            this.财富DataGridViewTextBoxColumn,
            this.中奖号码DataGridViewTextBoxColumn,
            this.流水号DataGridViewTextBoxColumn,
            this.编号DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usertotalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(444, 314);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usertotalBindingSource
            // 
            this.usertotalBindingSource.DataMember = "user_total";
            this.usertotalBindingSource.DataSource = this.database1DataSet;
            // 
            // user_totalTableAdapter
            // 
            this.user_totalTableAdapter.ClearBeforeFill = true;
            // 
            // 账号DataGridViewTextBoxColumn
            // 
            this.账号DataGridViewTextBoxColumn.DataPropertyName = "账号";
            this.账号DataGridViewTextBoxColumn.HeaderText = "账号";
            this.账号DataGridViewTextBoxColumn.Name = "账号DataGridViewTextBoxColumn";
            // 
            // 昵称DataGridViewTextBoxColumn
            // 
            this.昵称DataGridViewTextBoxColumn.DataPropertyName = "昵称";
            this.昵称DataGridViewTextBoxColumn.HeaderText = "昵称";
            this.昵称DataGridViewTextBoxColumn.Name = "昵称DataGridViewTextBoxColumn";
            // 
            // 财富DataGridViewTextBoxColumn
            // 
            this.财富DataGridViewTextBoxColumn.DataPropertyName = "财富";
            this.财富DataGridViewTextBoxColumn.HeaderText = "财富";
            this.财富DataGridViewTextBoxColumn.Name = "财富DataGridViewTextBoxColumn";
            // 
            // 中奖号码DataGridViewTextBoxColumn
            // 
            this.中奖号码DataGridViewTextBoxColumn.DataPropertyName = "中奖号码";
            this.中奖号码DataGridViewTextBoxColumn.HeaderText = "中奖号码";
            this.中奖号码DataGridViewTextBoxColumn.Name = "中奖号码DataGridViewTextBoxColumn";
            // 
            // 流水号DataGridViewTextBoxColumn
            // 
            this.流水号DataGridViewTextBoxColumn.DataPropertyName = "流水号";
            this.流水号DataGridViewTextBoxColumn.HeaderText = "流水号";
            this.流水号DataGridViewTextBoxColumn.Name = "流水号DataGridViewTextBoxColumn";
            // 
            // 编号DataGridViewTextBoxColumn
            // 
            this.编号DataGridViewTextBoxColumn.DataPropertyName = "编号";
            this.编号DataGridViewTextBoxColumn.HeaderText = "编号";
            this.编号DataGridViewTextBoxColumn.Name = "编号DataGridViewTextBoxColumn";
            // 
            // 查询ToolStrip
            // 
            this.查询ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询ToolStripButton});
            this.查询ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.查询ToolStrip.Name = "查询ToolStrip";
            this.查询ToolStrip.Size = new System.Drawing.Size(475, 25);
            this.查询ToolStrip.TabIndex = 4;
            this.查询ToolStrip.Text = "查询ToolStrip";
            // 
            // 查询ToolStripButton
            // 
            this.查询ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.查询ToolStripButton.Name = "查询ToolStripButton";
            this.查询ToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.查询ToolStripButton.Text = "查询";
            this.查询ToolStripButton.Click += new System.EventHandler(this.查询ToolStripButton_Click);
            // 
            // frm_money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 420);
            this.Controls.Add(this.查询ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frm_money";
            this.Text = "充值";
            this.Load += new System.EventHandler(this.frm_money_Load);
            //((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertotalBindingSource)).EndInit();
            this.查询ToolStrip.ResumeLayout(false);
            this.查询ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource usertotalBindingSource;
        private Database1DataSetTableAdapters.user_totalTableAdapter user_totalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 昵称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 财富DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 中奖号码DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 流水号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip 查询ToolStrip;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
    }
}
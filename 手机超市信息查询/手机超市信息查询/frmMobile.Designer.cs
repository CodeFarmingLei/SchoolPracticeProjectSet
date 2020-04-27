namespace 手机超市信息查询
{
    partial class frmMobile
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewRead = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxRead = new System.Windows.Forms.GroupBox();
            this.textBoxTJ = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonQC = new System.Windows.Forms.Button();
            this.buttonCX = new System.Windows.Forms.Button();
            this.labelTJ = new System.Windows.Forms.Label();
            this.comboBoxZL = new System.Windows.Forms.ComboBox();
            this.labelZL = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRead)).BeginInit();
            this.groupBoxRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRead
            // 
            this.dataGridViewRead.AllowDrop = true;
            this.dataGridViewRead.AllowUserToAddRows = false;
            this.dataGridViewRead.AllowUserToDeleteRows = false;
            this.dataGridViewRead.AllowUserToOrderColumns = true;
            this.dataGridViewRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewRead.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRead.Name = "dataGridViewRead";
            this.dataGridViewRead.ReadOnly = true;
            this.dataGridViewRead.RowTemplate.Height = 23;
            this.dataGridViewRead.Size = new System.Drawing.Size(704, 322);
            this.dataGridViewRead.TabIndex = 0;
            this.dataGridViewRead.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRead_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "序号";
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "品牌";
            this.Column2.HeaderText = "品牌";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "手机类型";
            this.Column3.HeaderText = "手机类型";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "型号";
            this.Column4.HeaderText = "型号";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "价格";
            this.Column5.HeaderText = "价格";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // groupBoxRead
            // 
            this.groupBoxRead.Controls.Add(this.textBoxTJ);
            this.groupBoxRead.Controls.Add(this.buttonExit);
            this.groupBoxRead.Controls.Add(this.buttonQC);
            this.groupBoxRead.Controls.Add(this.buttonCX);
            this.groupBoxRead.Controls.Add(this.labelTJ);
            this.groupBoxRead.Controls.Add(this.comboBoxZL);
            this.groupBoxRead.Controls.Add(this.labelZL);
            this.groupBoxRead.Location = new System.Drawing.Point(12, 340);
            this.groupBoxRead.Name = "groupBoxRead";
            this.groupBoxRead.Size = new System.Drawing.Size(704, 100);
            this.groupBoxRead.TabIndex = 1;
            this.groupBoxRead.TabStop = false;
            this.groupBoxRead.Text = "手机信息查询";
            // 
            // textBoxTJ
            // 
            this.textBoxTJ.Location = new System.Drawing.Point(279, 40);
            this.textBoxTJ.Name = "textBoxTJ";
            this.textBoxTJ.Size = new System.Drawing.Size(132, 21);
            this.textBoxTJ.TabIndex = 7;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(623, 38);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "退 出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonQC
            // 
            this.buttonQC.Location = new System.Drawing.Point(527, 38);
            this.buttonQC.Name = "buttonQC";
            this.buttonQC.Size = new System.Drawing.Size(75, 23);
            this.buttonQC.TabIndex = 5;
            this.buttonQC.Text = "清 除";
            this.buttonQC.UseVisualStyleBackColor = true;
            this.buttonQC.Click += new System.EventHandler(this.buttonQC_Click);
            // 
            // buttonCX
            // 
            this.buttonCX.Location = new System.Drawing.Point(432, 38);
            this.buttonCX.Name = "buttonCX";
            this.buttonCX.Size = new System.Drawing.Size(75, 23);
            this.buttonCX.TabIndex = 4;
            this.buttonCX.Text = "查 询";
            this.buttonCX.UseVisualStyleBackColor = true;
            this.buttonCX.Click += new System.EventHandler(this.buttonCX_Click);
            // 
            // labelTJ
            // 
            this.labelTJ.AutoSize = true;
            this.labelTJ.Location = new System.Drawing.Point(214, 43);
            this.labelTJ.Name = "labelTJ";
            this.labelTJ.Size = new System.Drawing.Size(59, 12);
            this.labelTJ.TabIndex = 2;
            this.labelTJ.Text = "查询条件:";
            // 
            // comboBoxZL
            // 
            this.comboBoxZL.FormattingEnabled = true;
            this.comboBoxZL.Items.AddRange(new object[] {
            "全部",
            "品牌",
            "手机类型"});
            this.comboBoxZL.Location = new System.Drawing.Point(85, 40);
            this.comboBoxZL.Name = "comboBoxZL";
            this.comboBoxZL.Size = new System.Drawing.Size(121, 20);
            this.comboBoxZL.TabIndex = 1;
            this.comboBoxZL.SelectedIndexChanged += new System.EventHandler(this.comboBoxZL_SelectedIndexChanged);
            // 
            // labelZL
            // 
            this.labelZL.AutoSize = true;
            this.labelZL.Location = new System.Drawing.Point(20, 43);
            this.labelZL.Name = "labelZL";
            this.labelZL.Size = new System.Drawing.Size(59, 12);
            this.labelZL.TabIndex = 0;
            this.labelZL.Text = "查询种类:";
            // 
            // frmMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 451);
            this.Controls.Add(this.groupBoxRead);
            this.Controls.Add(this.dataGridViewRead);
            this.MaximizeBox = false;
            this.Name = "frmMobile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "手机超市信息查询";
            this.Load += new System.EventHandler(this.frmMobile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRead)).EndInit();
            this.groupBoxRead.ResumeLayout(false);
            this.groupBoxRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRead;
        private System.Windows.Forms.GroupBox groupBoxRead;
        private System.Windows.Forms.Label labelZL;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonQC;
        private System.Windows.Forms.Button buttonCX;
        private System.Windows.Forms.Label labelTJ;
        private System.Windows.Forms.ComboBox comboBoxZL;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBoxTJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}


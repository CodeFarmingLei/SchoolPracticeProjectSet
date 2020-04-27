namespace 超市会员管理系统
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxGroup = new System.Windows.Forms.GroupBox();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.radioButtonBoJin = new System.Windows.Forms.RadioButton();
            this.radioButtonJin = new System.Windows.Forms.RadioButton();
            this.labelZT = new System.Windows.Forms.Label();
            this.labelJF = new System.Windows.Forms.Label();
            this.comboBoxZT = new System.Windows.Forms.ComboBox();
            this.textBoxJF = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("华文隶书", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(171, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(303, 35);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "超市会员管理系统";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(22, 67);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(41, 12);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "账号：";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(313, 67);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(41, 12);
            this.labelPwd.TabIndex = 2;
            this.labelPwd.Text = "密码：";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(69, 64);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(141, 21);
            this.textBoxUser.TabIndex = 3;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(360, 64);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(141, 21);
            this.textBoxPwd.TabIndex = 4;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(535, 64);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(89, 26);
            this.buttonInsert.TabIndex = 5;
            this.buttonInsert.Text = "添加";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(535, 96);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 26);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // groupBoxGroup
            // 
            this.groupBoxGroup.Controls.Add(this.radioButton);
            this.groupBoxGroup.Controls.Add(this.radioButtonBoJin);
            this.groupBoxGroup.Controls.Add(this.radioButtonJin);
            this.groupBoxGroup.Location = new System.Drawing.Point(24, 91);
            this.groupBoxGroup.Name = "groupBoxGroup";
            this.groupBoxGroup.Size = new System.Drawing.Size(477, 72);
            this.groupBoxGroup.TabIndex = 7;
            this.groupBoxGroup.TabStop = false;
            this.groupBoxGroup.Text = "卡别：";
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(383, 31);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(59, 16);
            this.radioButton.TabIndex = 2;
            this.radioButton.Text = "钻石卡";
            this.radioButton.UseVisualStyleBackColor = true;
            // 
            // radioButtonBoJin
            // 
            this.radioButtonBoJin.AutoSize = true;
            this.radioButtonBoJin.Location = new System.Drawing.Point(198, 31);
            this.radioButtonBoJin.Name = "radioButtonBoJin";
            this.radioButtonBoJin.Size = new System.Drawing.Size(59, 16);
            this.radioButtonBoJin.TabIndex = 1;
            this.radioButtonBoJin.Text = "铂金卡";
            this.radioButtonBoJin.UseVisualStyleBackColor = true;
            // 
            // radioButtonJin
            // 
            this.radioButtonJin.AutoSize = true;
            this.radioButtonJin.Checked = true;
            this.radioButtonJin.Location = new System.Drawing.Point(31, 31);
            this.radioButtonJin.Name = "radioButtonJin";
            this.radioButtonJin.Size = new System.Drawing.Size(47, 16);
            this.radioButtonJin.TabIndex = 0;
            this.radioButtonJin.TabStop = true;
            this.radioButtonJin.Text = "金卡";
            this.radioButtonJin.UseVisualStyleBackColor = true;
            // 
            // labelZT
            // 
            this.labelZT.AutoSize = true;
            this.labelZT.Location = new System.Drawing.Point(22, 190);
            this.labelZT.Name = "labelZT";
            this.labelZT.Size = new System.Drawing.Size(41, 12);
            this.labelZT.TabIndex = 8;
            this.labelZT.Text = "状态：";
            // 
            // labelJF
            // 
            this.labelJF.AutoSize = true;
            this.labelJF.Location = new System.Drawing.Point(289, 189);
            this.labelJF.Name = "labelJF";
            this.labelJF.Size = new System.Drawing.Size(65, 12);
            this.labelJF.TabIndex = 9;
            this.labelJF.Text = "账户积分：";
            // 
            // comboBoxZT
            // 
            this.comboBoxZT.FormattingEnabled = true;
            this.comboBoxZT.Location = new System.Drawing.Point(69, 187);
            this.comboBoxZT.Name = "comboBoxZT";
            this.comboBoxZT.Size = new System.Drawing.Size(121, 20);
            this.comboBoxZT.TabIndex = 10;
            // 
            // textBoxJF
            // 
            this.textBoxJF.Location = new System.Drawing.Point(360, 186);
            this.textBoxJF.Name = "textBoxJF";
            this.textBoxJF.ReadOnly = true;
            this.textBoxJF.Size = new System.Drawing.Size(141, 21);
            this.textBoxJF.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(2, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(650, 356);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerId";
            this.Column1.HeaderText = "账号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerType";
            this.Column2.HeaderText = "卡别";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Score";
            this.Column3.HeaderText = "积分";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StatesName";
            this.Column4.HeaderText = "状态";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 585);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxJF);
            this.Controls.Add(this.comboBoxZT);
            this.Controls.Add(this.labelJF);
            this.Controls.Add(this.labelZT);
            this.Controls.Add(this.groupBoxGroup);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市会员管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBoxGroup.ResumeLayout(false);
            this.groupBoxGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxGroup;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.RadioButton radioButtonBoJin;
        private System.Windows.Forms.RadioButton radioButtonJin;
        private System.Windows.Forms.Label labelZT;
        private System.Windows.Forms.Label labelJF;
        private System.Windows.Forms.ComboBox comboBoxZT;
        private System.Windows.Forms.TextBox textBoxJF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}


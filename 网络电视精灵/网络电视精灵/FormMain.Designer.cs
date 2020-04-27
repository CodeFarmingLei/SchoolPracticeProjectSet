namespace 网络电视精灵
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.更新节目单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提醒管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.加入到我的电视台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBJ = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除节目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBJ)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFH)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新节目单ToolStripMenuItem,
            this.提醒管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 更新节目单ToolStripMenuItem
            // 
            this.更新节目单ToolStripMenuItem.Name = "更新节目单ToolStripMenuItem";
            this.更新节目单ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.更新节目单ToolStripMenuItem.Text = "更新节目单";
            // 
            // 提醒管理ToolStripMenuItem
            // 
            this.提醒管理ToolStripMenuItem.Name = "提醒管理ToolStripMenuItem";
            this.提醒管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.提醒管理ToolStripMenuItem.Text = "提醒管理";
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(12, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(287, 486);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加入到我的电视台ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 26);
            // 
            // 加入到我的电视台ToolStripMenuItem
            // 
            this.加入到我的电视台ToolStripMenuItem.Name = "加入到我的电视台ToolStripMenuItem";
            this.加入到我的电视台ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.加入到我的电视台ToolStripMenuItem.Text = "加入到我的电视台";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvFH);
            this.tabPage1.Controls.Add(this.dgvBJ);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "节目";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBJ
            // 
            this.dgvBJ.AllowUserToAddRows = false;
            this.dgvBJ.AllowUserToDeleteRows = false;
            this.dgvBJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBJ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvBJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBJ.Location = new System.Drawing.Point(3, 3);
            this.dgvBJ.Name = "dgvBJ";
            this.dgvBJ.RowTemplate.Height = 23;
            this.dgvBJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBJ.Size = new System.Drawing.Size(645, 454);
            this.dgvBJ.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "playTime";
            this.Column1.HeaderText = "播放时间";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "programName";
            this.Column2.HeaderText = "节目名称";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(305, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 486);
            this.tabControl1.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除节目ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(125, 26);
            // 
            // 删除节目ToolStripMenuItem
            // 
            this.删除节目ToolStripMenuItem.Name = "删除节目ToolStripMenuItem";
            this.删除节目ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除节目ToolStripMenuItem.Text = "删除节目";
            // 
            // dgvFH
            // 
            this.dgvFH.AllowUserToAddRows = false;
            this.dgvFH.AllowUserToDeleteRows = false;
            this.dgvFH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvFH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFH.Location = new System.Drawing.Point(3, 3);
            this.dgvFH.Name = "dgvFH";
            this.dgvFH.RowTemplate.Height = 23;
            this.dgvFH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFH.Size = new System.Drawing.Size(645, 454);
            this.dgvFH.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "playTime";
            this.dataGridViewTextBoxColumn1.HeaderText = "播放时间";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "节目名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 524);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "网络电视精灵";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBJ)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 更新节目单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提醒管理ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvBJ;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 加入到我的电视台ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 删除节目ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvFH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}


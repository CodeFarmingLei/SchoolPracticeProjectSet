namespace _2018中超联赛系统
{
    partial class MainForm
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
            this.球队管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.赛程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.赛程添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.赛程查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.球队管理ToolStripMenuItem,
            this.赛程管理ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 球队管理ToolStripMenuItem
            // 
            this.球队管理ToolStripMenuItem.Name = "球队管理ToolStripMenuItem";
            this.球队管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.球队管理ToolStripMenuItem.Text = "球队管理";
            this.球队管理ToolStripMenuItem.Click += new System.EventHandler(this.球队管理ToolStripMenuItem_Click);
            // 
            // 赛程管理ToolStripMenuItem
            // 
            this.赛程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.赛程添加ToolStripMenuItem,
            this.赛程查询ToolStripMenuItem});
            this.赛程管理ToolStripMenuItem.Name = "赛程管理ToolStripMenuItem";
            this.赛程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.赛程管理ToolStripMenuItem.Text = "赛程管理";
            // 
            // 赛程添加ToolStripMenuItem
            // 
            this.赛程添加ToolStripMenuItem.Name = "赛程添加ToolStripMenuItem";
            this.赛程添加ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.赛程添加ToolStripMenuItem.Text = "赛程添加";
            this.赛程添加ToolStripMenuItem.Click += new System.EventHandler(this.赛程添加ToolStripMenuItem_Click);
            // 
            // 赛程查询ToolStripMenuItem
            // 
            this.赛程查询ToolStripMenuItem.Name = "赛程查询ToolStripMenuItem";
            this.赛程查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.赛程查询ToolStripMenuItem.Text = "赛程查询";
            this.赛程查询ToolStripMenuItem.Click += new System.EventHandler(this.赛程查询ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 408);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2018中超赛事管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 球队管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 赛程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 赛程添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 赛程查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}


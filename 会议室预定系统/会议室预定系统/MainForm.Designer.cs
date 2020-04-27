namespace 会议室预定系统
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.会议室管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预定会议室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询预定情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.会议纪要系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.会议室管理ToolStripMenuItem,
            this.会议纪要系统ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 会议室管理ToolStripMenuItem
            // 
            this.会议室管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.预定会议室ToolStripMenuItem,
            this.查询预定情况ToolStripMenuItem});
            this.会议室管理ToolStripMenuItem.Name = "会议室管理ToolStripMenuItem";
            this.会议室管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.会议室管理ToolStripMenuItem.Text = "会议室管理";
            this.会议室管理ToolStripMenuItem.Click += new System.EventHandler(this.会议室管理ToolStripMenuItem_Click);
            // 
            // 预定会议室ToolStripMenuItem
            // 
            this.预定会议室ToolStripMenuItem.Name = "预定会议室ToolStripMenuItem";
            this.预定会议室ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.预定会议室ToolStripMenuItem.Text = "预定会议室";
            this.预定会议室ToolStripMenuItem.Click += new System.EventHandler(this.预定会议室ToolStripMenuItem_Click);
            // 
            // 查询预定情况ToolStripMenuItem
            // 
            this.查询预定情况ToolStripMenuItem.Name = "查询预定情况ToolStripMenuItem";
            this.查询预定情况ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查询预定情况ToolStripMenuItem.Text = "查询预定情况";
            this.查询预定情况ToolStripMenuItem.Click += new System.EventHandler(this.查询预定情况ToolStripMenuItem_Click);
            // 
            // 会议纪要系统ToolStripMenuItem
            // 
            this.会议纪要系统ToolStripMenuItem.Name = "会议纪要系统ToolStripMenuItem";
            this.会议纪要系统ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.会议纪要系统ToolStripMenuItem.Text = "会议纪要系统";
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
            this.ClientSize = new System.Drawing.Size(990, 656);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会议室预订系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 会议室管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预定会议室ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询预定情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会议纪要系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
    }
}


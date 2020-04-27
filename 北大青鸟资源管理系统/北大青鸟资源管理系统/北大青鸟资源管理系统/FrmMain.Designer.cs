namespace 北大青鸟资源管理系统
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.占用资源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.资源查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.占用教室机房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教室机房占用情况查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.占用资源ToolStripMenuItem,
            this.资源查询ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 占用资源ToolStripMenuItem
            // 
            this.占用资源ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.占用教室机房ToolStripMenuItem});
            this.占用资源ToolStripMenuItem.Name = "占用资源ToolStripMenuItem";
            this.占用资源ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.占用资源ToolStripMenuItem.Text = "占用资源";
            // 
            // 资源查询ToolStripMenuItem
            // 
            this.资源查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.教室机房占用情况查询ToolStripMenuItem});
            this.资源查询ToolStripMenuItem.Name = "资源查询ToolStripMenuItem";
            this.资源查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.资源查询ToolStripMenuItem.Text = "资源查询";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 占用教室机房ToolStripMenuItem
            // 
            this.占用教室机房ToolStripMenuItem.Name = "占用教室机房ToolStripMenuItem";
            this.占用教室机房ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.占用教室机房ToolStripMenuItem.Text = "占用教室机房";
            this.占用教室机房ToolStripMenuItem.Click += new System.EventHandler(this.占用教室机房ToolStripMenuItem_Click);
            // 
            // 教室机房占用情况查询ToolStripMenuItem
            // 
            this.教室机房占用情况查询ToolStripMenuItem.Name = "教室机房占用情况查询ToolStripMenuItem";
            this.教室机房占用情况查询ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.教室机房占用情况查询ToolStripMenuItem.Text = "教室机房占用情况查询";
            this.教室机房占用情况查询ToolStripMenuItem.Click += new System.EventHandler(this.教室机房占用情况查询ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 606);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "北大青鸟资源管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 占用资源ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 资源查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 占用教室机房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教室机房占用情况查询ToolStripMenuItem;
    }
}


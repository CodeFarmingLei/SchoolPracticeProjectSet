﻿namespace 证件管理系统
{
    partial class frmMain
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
            this.证件管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.证件注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.证件查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.证件注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.证件管理ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 证件管理ToolStripMenuItem
            // 
            this.证件管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.证件注册ToolStripMenuItem,
            this.证件查询ToolStripMenuItem,
            this.证件注销ToolStripMenuItem});
            this.证件管理ToolStripMenuItem.Name = "证件管理ToolStripMenuItem";
            this.证件管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.证件管理ToolStripMenuItem.Text = "证件管理";
            // 
            // 证件注册ToolStripMenuItem
            // 
            this.证件注册ToolStripMenuItem.Name = "证件注册ToolStripMenuItem";
            this.证件注册ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.证件注册ToolStripMenuItem.Text = "证件注册";
            // 
            // 证件查询ToolStripMenuItem
            // 
            this.证件查询ToolStripMenuItem.Name = "证件查询ToolStripMenuItem";
            this.证件查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.证件查询ToolStripMenuItem.Text = "证件查询";
            this.证件查询ToolStripMenuItem.Click += new System.EventHandler(this.证件查询ToolStripMenuItem_Click);
            // 
            // 证件注销ToolStripMenuItem
            // 
            this.证件注销ToolStripMenuItem.Name = "证件注销ToolStripMenuItem";
            this.证件注销ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.证件注销ToolStripMenuItem.Text = "证件注销";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 454);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "证件管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 证件管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 证件注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 证件查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 证件注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}


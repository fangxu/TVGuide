namespace TVGuide
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemCCTV = new System.Windows.Forms.ToolStripMenuItem();
            this.卫视ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地方ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.星期一ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.星期二ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.星期三ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.星期四ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.星期五ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.星期六ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.星期日ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStripContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStripContainer1);
            this.splitContainer1.Size = new System.Drawing.Size(626, 389);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.splitContainer2);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(221, 364);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(221, 389);
            this.toolStripContainer2.TabIndex = 0;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.menuStrip2);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBox2);
            this.splitContainer2.Size = new System.Drawing.Size(221, 364);
            this.splitContainer2.SplitterDistance = 95;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(95, 364);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(122, 364);
            this.listBox2.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCCTV,
            this.卫视ToolStripMenuItem,
            this.地方ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(221, 25);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ToolStripMenuItemCCTV
            // 
            this.ToolStripMenuItemCCTV.Name = "ToolStripMenuItemCCTV";
            this.ToolStripMenuItemCCTV.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItemCCTV.Text = "央视";
            this.ToolStripMenuItemCCTV.Click += new System.EventHandler(this.ToolStripMenuItemCCTV_Click);
            // 
            // 卫视ToolStripMenuItem
            // 
            this.卫视ToolStripMenuItem.Name = "卫视ToolStripMenuItem";
            this.卫视ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.卫视ToolStripMenuItem.Text = "卫视";
            // 
            // 地方ToolStripMenuItem
            // 
            this.地方ToolStripMenuItem.Name = "地方ToolStripMenuItem";
            this.地方ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.地方ToolStripMenuItem.Text = "地方";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listView1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(401, 364);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(401, 389);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(401, 364);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.星期一ToolStripMenuItem,
            this.星期二ToolStripMenuItem,
            this.星期三ToolStripMenuItem,
            this.星期四ToolStripMenuItem,
            this.星期五ToolStripMenuItem,
            this.星期六ToolStripMenuItem,
            this.星期日ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 星期一ToolStripMenuItem
            // 
            this.星期一ToolStripMenuItem.Name = "星期一ToolStripMenuItem";
            this.星期一ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.星期一ToolStripMenuItem.Text = "星期一";
            // 
            // 星期二ToolStripMenuItem
            // 
            this.星期二ToolStripMenuItem.Name = "星期二ToolStripMenuItem";
            this.星期二ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.星期二ToolStripMenuItem.Text = "星期二";
            // 
            // 星期三ToolStripMenuItem
            // 
            this.星期三ToolStripMenuItem.Name = "星期三ToolStripMenuItem";
            this.星期三ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.星期三ToolStripMenuItem.Text = "星期三";
            // 
            // 星期四ToolStripMenuItem
            // 
            this.星期四ToolStripMenuItem.Name = "星期四ToolStripMenuItem";
            this.星期四ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.星期四ToolStripMenuItem.Text = "星期四";
            // 
            // 星期五ToolStripMenuItem
            // 
            this.星期五ToolStripMenuItem.Name = "星期五ToolStripMenuItem";
            this.星期五ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.星期五ToolStripMenuItem.Text = "星期五";
            // 
            // 星期六ToolStripMenuItem
            // 
            this.星期六ToolStripMenuItem.Name = "星期六ToolStripMenuItem";
            this.星期六ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.星期六ToolStripMenuItem.Text = "星期六";
            // 
            // 星期日ToolStripMenuItem
            // 
            this.星期日ToolStripMenuItem.Name = "星期日ToolStripMenuItem";
            this.星期日ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.星期日ToolStripMenuItem.Text = "星期日";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 389);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 星期一ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 星期二ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 星期三ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 星期四ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 星期五ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 星期六ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 星期日ToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCCTV;
        private System.Windows.Forms.ToolStripMenuItem 卫视ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地方ToolStripMenuItem;
    }
}


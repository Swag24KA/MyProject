namespace MyLibrary
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.书籍管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书借还TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者增改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销毁读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户增改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.用户注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel9});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1061, 31);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 24);
            this.toolStripStatusLabel1.Text = "登录用户:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(15, 24);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(86, 24);
            this.toolStripStatusLabel4.Text = "用户权限:";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(15, 24);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(86, 24);
            this.toolStripStatusLabel6.Text = "登录时间:";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(0, 24);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.书籍管理ToolStripMenuItem,
            this.图书借还TToolStripMenuItem,
            this.读者管理PToolStripMenuItem,
            this.用户管理UToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.退出TToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 书籍管理ToolStripMenuItem
            // 
            this.书籍管理ToolStripMenuItem.Name = "书籍管理ToolStripMenuItem";
            this.书籍管理ToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.书籍管理ToolStripMenuItem.Text = "书籍管理[B]";
            this.书籍管理ToolStripMenuItem.Click += new System.EventHandler(this.书籍管理ToolStripMenuItem_Click);
            // 
            // 图书借还TToolStripMenuItem
            // 
            this.图书借还TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书ToolStripMenuItem,
            this.还书ToolStripMenuItem});
            this.图书借还TToolStripMenuItem.Name = "图书借还TToolStripMenuItem";
            this.图书借还TToolStripMenuItem.Size = new System.Drawing.Size(128, 28);
            this.图书借还TToolStripMenuItem.Text = "图书借还[M]";
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.借书ToolStripMenuItem.Text = "借书管理";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 还书ToolStripMenuItem
            // 
            this.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem";
            this.还书ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.还书ToolStripMenuItem.Text = "还书管理";
            this.还书ToolStripMenuItem.Click += new System.EventHandler(this.还书ToolStripMenuItem_Click);
            // 
            // 读者管理PToolStripMenuItem
            // 
            this.读者管理PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者增改ToolStripMenuItem,
            this.销毁读者ToolStripMenuItem});
            this.读者管理PToolStripMenuItem.Name = "读者管理PToolStripMenuItem";
            this.读者管理PToolStripMenuItem.Size = new System.Drawing.Size(122, 28);
            this.读者管理PToolStripMenuItem.Text = "读者管理[R]";
            this.读者管理PToolStripMenuItem.Click += new System.EventHandler(this.读者管理PToolStripMenuItem_Click);
            // 
            // 读者增改ToolStripMenuItem
            // 
            this.读者增改ToolStripMenuItem.Name = "读者增改ToolStripMenuItem";
            this.读者增改ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.读者增改ToolStripMenuItem.Text = "读者增改";
            this.读者增改ToolStripMenuItem.Click += new System.EventHandler(this.读者增改ToolStripMenuItem_Click);
            // 
            // 销毁读者ToolStripMenuItem
            // 
            this.销毁读者ToolStripMenuItem.Name = "销毁读者ToolStripMenuItem";
            this.销毁读者ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.销毁读者ToolStripMenuItem.Text = "销毁读者";
            this.销毁读者ToolStripMenuItem.Click += new System.EventHandler(this.销毁读者ToolStripMenuItem_Click);
            // 
            // 用户管理UToolStripMenuItem
            // 
            this.用户管理UToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户增改ToolStripMenuItem,
            this.用户注销ToolStripMenuItem});
            this.用户管理UToolStripMenuItem.Name = "用户管理UToolStripMenuItem";
            this.用户管理UToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.用户管理UToolStripMenuItem.Text = "用户管理[U]";
            // 
            // 用户增改ToolStripMenuItem
            // 
            this.用户增改ToolStripMenuItem.Name = "用户增改ToolStripMenuItem";
            this.用户增改ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.用户增改ToolStripMenuItem.Text = "用户增改";
            this.用户增改ToolStripMenuItem.Click += new System.EventHandler(this.用户增改ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(88, 28);
            this.帮助HToolStripMenuItem.Text = "帮助[H]";
            // 
            // 退出TToolStripMenuItem
            // 
            this.退出TToolStripMenuItem.Name = "退出TToolStripMenuItem";
            this.退出TToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.退出TToolStripMenuItem.Text = "退出[T]";
            this.退出TToolStripMenuItem.Click += new System.EventHandler(this.退出TToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 584);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // 用户注销ToolStripMenuItem
            // 
            this.用户注销ToolStripMenuItem.Name = "用户注销ToolStripMenuItem";
            this.用户注销ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.用户注销ToolStripMenuItem.Text = "用户注销";
            this.用户注销ToolStripMenuItem.Click += new System.EventHandler(this.用户注销ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 书籍管理ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripMenuItem 图书借还TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者管理PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者增改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销毁读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户增改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户注销ToolStripMenuItem;
    }
}
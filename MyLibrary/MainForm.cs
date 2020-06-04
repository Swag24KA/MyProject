using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string name, bean, time;

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow br = new Borrow();
            br.Show();
        }

        private void 退出TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
             
        }

        private void 读者管理PToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 读者增改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderManager rm = new ReaderManager();
            rm.Show();
        }

        private void 销毁读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderDel rd = new ReaderDel();
            rd.Show();
        }

        private void 用户增改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManager um = new UserManager();
            um.Show();
        }

        private void 用户注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDel ud = new UserDel();
            ud.Show();
        }

        private void 书籍管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookManager bm = new BookManager();
         
            bm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (bean == "普通管理员")
            {
                bean = "普通管理员";
                用户管理UToolStripMenuItem.Enabled = false;
            }
            else { 
                bean = "超级管理员";
            }
            toolStripStatusLabel7.Text = name;
            toolStripStatusLabel8.Text = bean;
            toolStripStatusLabel9.Text = time;
        }
    }
}

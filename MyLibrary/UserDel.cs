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
    public partial class UserDel : Form
    {
        public UserDel()
        {
            InitializeComponent();
        }
        public void all()
        {
            string sql = "select * from tuser";
            DataTable dt = SqlHelper.GetTable(sql);
            dataGridView1.DataSource = dt;
        }
        private void UserDel_Load(object sender, EventArgs e)
        {
            all();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户账号！");
                return;
            }
            string num = textBox1.Text;
            string sql = string.Format("delete from tuser where UserNum='{0}'", num);

            try
            {
                //执行并返回
                if (SqlHelper.ExcuteNonQuery(sql) > 0)
                {
                    textBox1.Text = "";
                    all();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错！" + ex.Message);
            }
        
    }
    }
}

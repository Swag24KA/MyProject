using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyLibrary
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        public void all()
        {
            string sql = "select * from lend";
            DataTable dt = SqlHelper.GetTable(sql);
            dataGridView1.DataSource = dt;
        }
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            all();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入图书ID！");
                return;
            }
            string id = textBox1.Text;
            string sql = string.Format("delete from lend where BookID='{0}'", id);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

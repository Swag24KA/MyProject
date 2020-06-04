using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyLibrary
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }
        string constring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void clean() {
            dateTimePicker1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入借书证号!");
                return;
            }
            string id = textBox1.Text.Trim();

            string sql = string.Format("select * from reader where ReaderID = '{0}'", id);
            using (SqlConnection con = new SqlConnection(constring))
            {

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("用户存在");
                        button2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("用户不存在");
                    }


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == ""||textBox3.Text.Trim()=="")
            {
                MessageBox.Show("请输如完整!");
                return;
            }
            string readerid = textBox1.Text.Trim();
            string isbn = textBox2.Text;
            string bookid = textBox3.Text;
            string bookName = textBox4.Text;
            string time = dateTimePicker1.Text;
            string sql = string.Format("insert into lend  values('{0}','{1}','{2}','{3}','{4}')",
                bookid,readerid,isbn, bookName,time);

            try
            {
                //执行并返回
                if (SqlHelper.ExcuteNonQuery(sql) > 0)
                {
                    string sql1 = string.Format("select * from lend where  BookID='{0}'",bookid);
                    dataGridView1.DataSource = SqlHelper.GetTable(sql1);
                    clean();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错！" + ex.Message);
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;//获取选中行的索引
            if (i < 0)
                return;

            textBox3.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
       
        private void textBox4_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                string isbn = textBox2.Text;
                string sql = string.Format("select BookName from books where ISBN='{0}'", isbn);
                DataTable dt = SqlHelper.GetTable(sql);
                string bookname = dt.Rows[0][0].ToString();
                textBox4.Text = bookname;
            }
            catch (Exception ex) {
                MessageBox.Show("出错！" + ex.Message);
            }
        }
    }
}

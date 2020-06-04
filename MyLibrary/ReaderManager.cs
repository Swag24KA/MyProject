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
using System.Configuration;

namespace MyLibrary
{
    public partial class ReaderManager : Form
    {
        public ReaderManager()
        {
            InitializeComponent();
        }
        public void clear() {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }
        public void all()
        {
            string sql = "select * from reader";
            DataTable dt = SqlHelper.GetTable(sql);
            dataGridView1.DataSource = dt;
        }
        string constring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
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
                        string sql2 = string.Format("select * from reader where ReaderID = '{0}'", id);
                        dataGridView1.DataSource = SqlHelper.GetTable(sql2);
                        button2.Enabled = false;
                        button3.Enabled = true;
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("用户不存在");
                        button2.Enabled = true;
                        button3.Enabled = true;
                        clear();
                    }


                }

            }



        }

        private void textBox5_MouseMove(object sender, MouseEventArgs e)
        {
            string id = textBox1.Text.Trim();

            string sql1 = string.Format("select count (Reader) from lend where Reader='{0}'", id);
            DataTable dt = SqlHelper.GetTable(sql1);
            string bookname = dt.Rows[0][0].ToString();
            textBox5.Text = bookname;
            string sql2 = string.Format("update reader set Number='{0}' where ReaderID='{1}'", 
                bookname,id);
            DataTable dt1 = SqlHelper.GetTable(sql2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string studentid = textBox3.Text;
            string zy = textBox4.Text;
            string number = textBox5.Text;
            string sql = string.Format("insert into reader values('{0}','{1}','{2}','{3}','{4}')",
               id,name,studentid,zy,number);         
                DataTable dt = SqlHelper.GetTable(sql);
                dataGridView1.DataSource = dt;
            clear();
            string sql2 = string.Format("select * from reader where ReaderID = '{0}'", id);
            dataGridView1.DataSource = SqlHelper.GetTable(sql2);

        }

        private void ReaderManager_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;//获取选中行的索引
            if (i < 0)
                return;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string studentid = textBox3.Text;
            string zy = textBox4.Text;
            string sql = string.Format("update reader set Name='{0}',StudentID='{1}',Judrage='{2}'where ReaderID={3}",
                name,studentid,zy,id);

            //执行并返回
            if (SqlHelper.ExcuteNonQuery(sql) > 0)
            {
                clear();
                string sql2 = string.Format("select * from reader where ReaderID = '{0}'", id);
                dataGridView1.DataSource = SqlHelper.GetTable(sql2);
            }
        }
    }
}

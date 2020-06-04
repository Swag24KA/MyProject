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
using System.IO;
using System.Configuration;

namespace MyLibrary
{
    public partial class BookManager : Form
    {
        public BookManager()
        {
            InitializeComponent();
        }

        string constring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        //清空的方法
        public void clear() {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
        //获取所有的数据的方法
        public void all() {
            string sql = "select ISBN,BookName,Author,publisher,price,BookType,SNum,Summary from books";
            DataTable dt = SqlHelper.GetTable(sql);
            dataGridView1.DataSource = dt;
        }

        //图书添加
        private void button2_Click(object sender, EventArgs e)
        {
            //获取数据源
          

            if (textBox2.Text == "" || textBox3.Text == "" || textBox7.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("请输入完整！");
                return; 
            }
            string isbn= textBox6.Text;
            string bookname = textBox2.Text;
            string author = textBox3.Text;
            string publisher = textBox4.Text;
            decimal price = Convert.ToDecimal(textBox5.Text);
            string bookType = textBox7.Text;
            int SNum = Convert.ToInt32(textBox8.Text.Trim());
            string summary = textBox9.Text;
            //设置Sql语句
            string sql = string.Format("insert into books  values('{0}','{1}','{2}','{3}',{4},'{5}',{6},'{7}')"
                ,isbn,bookname,author,publisher,price,bookType,SNum,summary);

            try
            {
                //执行并返回
                if (SqlHelper.ExcuteNonQuery(sql) > 0)
                {
                    dataGridView1.DataSource = SqlHelper.GetTable(string.Format("select * from books where ISBN='{0}'", isbn));
                    clear();
                    all();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错！" + ex.Message);
            }

        }
        //datagradview显示
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;//获取选中行的索引
            if (i < 0)
                return;

            textBox6.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBox9.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void BookManager_Load(object sender, EventArgs e)
        {
          //  all();
        }

        //修改操作
        private void button3_Click(object sender, EventArgs e)
        {
            string isbn = textBox6.Text;
            string bookname = textBox2.Text;
            string author = textBox3.Text;
            string publisher = textBox4.Text;
            decimal price = Convert.ToDecimal(textBox5.Text);
            string bookType = textBox7.Text;
            int SNum = Convert.ToInt32(textBox8.Text.Trim());
            string summary = textBox9.Text;

            string sql = string.Format("update books set BookName='{0}',Author='{1}',publisher='{2}',price='{3}',BookType='{4}',SNum='{5}',Summary='{6}'where ISBN={7}",
               bookname,author,publisher,price,bookType,SNum,summary,isbn);
            try
            {
                //执行并返回
                if (SqlHelper.ExcuteNonQuery(sql) > 0)
                {
                    clear();
                    all();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错！" + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("确定要删除这条记录嘛？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                string isbn =textBox6.Text;
                string sql = string.Format("delete from books where ISBN={0}",isbn);
                if (SqlHelper.ExcuteNonQuery(sql) > 0)
                {   
                    clear();
                    all();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入图书!");
                return;
            }
            string sql = string.Format("select ISBN,BookName,Author,publisher,price,BookType,SNum,Summary from books where BookName like '%" + textBox1.Text.Trim() + "%'");
            SqlConnection conn = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);    //实例化数据库适配器
                    DataSet dstable = new DataSet();
                    adapter.Fill(dstable, "testTable");
                    dataGridView1.DataSource = dstable.Tables["testTable"];
                    dataGridView1.Show();

                    clear();       

            }
            catch (Exception ex)
            {
                MessageBox.Show("出错！" + ex.Message);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MyLibrary
{
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        public void all()
        {
            string sql = "select UserName,UserNum,UserPwd,do from tuser";
            DataTable dt = SqlHelper.GetTable(sql);
            dataGridView1.DataSource = dt;
        }

        private string getM5(String str)
        {
            //创建一个MD5对象
            MD5 md5 = MD5.Create();
            //把str转成字节数组
            byte[] old = Encoding.Default.GetBytes(str);
            //进行加密
            byte[] newpwd = md5.ComputeHash(old);
            //把字节数组转成String
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < newpwd.Length; i++)
                sb.Append(newpwd[i].ToString("x"));
            return sb.ToString();
        }
        private void UserManager_Load(object sender, EventArgs e)
        {
            all();

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string num = textBox2.Text;
            string pwd = getM5(textBox3.Text);
            string qx = textBox4.Text;
             
            string sql = string.Format("insert into tuser values('{0}','{1}','{2}','{3}')",
               num,name,pwd,qx);
            if (SqlHelper.ExcuteNonQuery(sql) > 0)
            {
                clear();
                all();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string num = textBox2.Text;
            string pwd = getM5(textBox3.Text);
            string qx = textBox4.Text;
            string sql = string.Format("update tuser set UserName='{0}',UserPwd='{1}',do='{2}'where UserNum={3}",
               name,pwd,qx, num);

            if (SqlHelper.ExcuteNonQuery(sql) > 0)
            {
                clear();
                all();
            }
        }
    }
}

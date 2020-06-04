using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace MyLibrary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("用户名和密码不能为空！");
                return;
            }
            string num = textBox1.Text.Trim();
            string pwd = getM5(textBox2.Text.Trim());
            string sql;
            if (radioButton1.Checked == true)
            {
                sql = string.Format("select * from tuser where UserNum='{0}' and UserPwd='{1}'", num, pwd);
               
            }
           else {
                sql = string.Format("select * from admin where UserNum='{0}' and UserPwd='{1}'", num, pwd);
            }


          

            using (SqlConnection con = new SqlConnection(constring))
            {

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (!dr.HasRows)
                    {
                        MessageBox.Show("用户名密码错误");
                    }



                    else
                    {
                        MainForm mf = new MainForm();
                        mf.name = dr[2].ToString();
                        mf.bean = dr[4].ToString().Trim();
                        mf.time = System.DateTime.Now.ToLongDateString();

              
                        mf.Show();
                        this.Hide();
                   

                    }


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

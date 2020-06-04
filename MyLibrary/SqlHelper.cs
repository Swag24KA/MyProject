using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace MyLibrary
{
    class SqlHelper
    {
        //获取连接
        static string constring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        //封装执行sql的方法
        public static int ExcuteNonQuery(string sql)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataTable GetTable(string sql)
        {
            SqlDataAdapter sdr = new SqlDataAdapter(sql, constring);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            return dt;
        }


    

}
}

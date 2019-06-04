using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace connquery
{
    public class connquery
    {
        private string connStr = "server=127.0.0.1;uid=root;database=test;CharSet=utf8";

        public void connsql(string cmd)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand sql = new MySqlCommand(cmd, conn);
            sql.ExecuteNonQuery();//僅返回受影響的資料列數目
            //sql.ExecuteReader(); //返回所有資料
            conn.Close();
        }

        public string connScalar(string cmd)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand sql = new MySqlCommand(cmd, conn);
            string data = sql.ExecuteScalar().ToString(); //返回單獨值
            conn.Close();
            return data;
        }

        private MySqlDataAdapter conn(string cmd)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd, conn);
            conn.Close();
            return adpt;
        }

        public DataTable conndt(string cmd)
        {
            DataTable dt = new DataTable();
            conn(cmd).Fill(dt);
            return dt;
        }

        public DataSet connds(string cmd)
        {
            DataSet ds = new DataSet();
            conn(cmd).Fill(ds);
            return ds;
        }

        public string mysqlip()
        {
            string my = connStr.Split(';')[0].Split('=')[1];
            return my;
        }
    }
}

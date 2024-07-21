using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NguyenCaoThang
{
    internal class Connection
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter dataadap;
        public string strComm = @"Data Source=CAOTHANG\SQLEXPRESS;Initial Catalog=QLNV_THUEHANGHOA;Integrated Security=True";
        public DataSet getDuLieu(string sql)
        {
            try
            {
                conn = new SqlConnection(strComm);
                conn.Open();

                dataadap = new SqlDataAdapter(sql, conn);
                DataSet d = new DataSet();
                dataadap.Fill(d, sql);
                conn.Close();
                return d;

            }
            catch (Exception e)
            {
                return null;
            }
        }
        public void ExecuteNonQuery(string sql)
        {
            try
            {
                conn = new SqlConnection(strComm);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();
                command.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {

            }
        }
    }
}

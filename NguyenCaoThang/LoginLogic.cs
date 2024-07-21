using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class LoginLogic
    {
        Connection conn = new Connection();
        LoginObj lgobj = new LoginObj();

        public DataSet getDataLogin(LoginObj lgo)
        {
            string sql = "Select * from login where username = N'" + lgo.Username + "' and password = N'" + lgo.Password + "'";
            return conn.getDuLieu(sql);
        }
        public DataSet getDataLogin()
        {
            string sql = "Select * from login";
            return conn.getDuLieu(sql);
        }
        public void Themdl(LoginObj lo)
        {
            string sql = "insert into Login(Username,Password) values ('" + lo.Username + "','" + lo.Password + "')";
            conn.ExecuteNonQuery(sql);
        }
        public void Xoadl(LoginObj lo)
        {
            string sql = "delete from login where username = '" + lo.Username + "'";
            conn.ExecuteNonQuery(sql);
        }
        public void Suadl(LoginObj lo)
        {
            string sql = "update login set password='" + lo.Password + "'where username='" + lo.Username + "'";
            conn.ExecuteNonQuery(sql);
        }
        public bool Kiemtrakey(string chuoi)
        {
            string sql = "Select * from login where username= '" + chuoi + "'";
            DataSet d = conn.getDuLieu(sql);
            if (d.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }
        public DataSet Search(String chuoi)
        {
            string sql = "Select * from login where username like '%" + chuoi + "%' or password like '" + chuoi + "'";
            return conn.getDuLieu(sql);
        }
    }
}

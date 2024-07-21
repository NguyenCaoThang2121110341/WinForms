using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class RentalLogic
    {
        Connection conn = new Connection();
        RentalObj rtobj = new RentalObj();

        public DataSet getDataRental(RentalObj lgo)
        {
            string sql = "select * from THUEHANGHOA where manv = N'" + lgo.Manv + "' and mahh = N'" + lgo.Mahh + "'";
            return conn.getDuLieu(sql);
        }
        public DataSet getDataRental()
        {
            string sql = "select * from THUEHANGHOA";
            return conn.getDuLieu(sql);
        }
        public void Themdl(RentalObj lo)
        {
            string sql = "insert into THUEHANGHOA([MANV],[MAHH]) values ('" + lo.Manv + "','" + lo.Mahh + "')";
            conn.ExecuteNonQuery(sql);
        }

        public void Xoadl(RentalObj lo)
        {
            string sql = "delete from  where manv = '" + lo.Manv + "'";
            conn.ExecuteNonQuery(sql);
        }
        public void Suadl(RentalObj lo)
        {
            string sql = "update THUEHANGHOA set MAHH='" + lo.Mahh + "'where MANV='" + lo.Manv + "'";
            conn.ExecuteNonQuery(sql);
        }
        public bool Kiemtrakey(string chuoi)
        {
            string sql = "Select * from THUEHANGHOA where username= '" + chuoi + "'";
            DataSet d = conn.getDuLieu(sql);
            if (d.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }
        public DataSet Search(String chuoi)
        {
            string sql = "Select * from THUEHANGHOA where MANV like '%" + chuoi + "%' or MAHH like '" + chuoi + "'";
            return conn.getDuLieu(sql);
        }
    }
}

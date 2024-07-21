using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class GoodsLogic
    {
        Connection conn = new Connection();
        GoodsObj rtobj = new GoodsObj();

        public DataSet getDataGoods(GoodsObj lgo)
        {
            string sql = "select * from HANGHOA where mahh = N'" + lgo.Mahh + "' and tenhh = N'" + lgo.Tenhh + "'and donvi = N'" + lgo.Donvi + "'and dongia = N'" + lgo.Dongia + "'";
            return conn.getDuLieu(sql);
        }
        public DataSet getDataGoods()
        {
            string sql = "select * from HANGHOA";
            return conn.getDuLieu(sql);
        }
        public void Themdl(GoodsObj lo)
        {
            string sql = "insert into HANGHOA([MAHH],[TENHH],[DONVI],[DONGIA]) values ('" + lo.Mahh + "','" + lo.Tenhh + "','" + lo.Donvi + "','" + lo.Dongia + "')";
            conn.ExecuteNonQuery(sql);
        }

        public void Xoadl(GoodsObj lo)
        {
            string sql = "delete from HANGHOA where MAHH = '" + lo.Mahh + "'";
            conn.ExecuteNonQuery(sql);
        }
        public void Suadl(GoodsObj lo)
        {
            string sql = "UPDATE HANGHOA set TENHH='" + lo.Tenhh + "' and DONVI = '" + lo.Donvi + "' and DONGIA = '" + lo.Dongia + "' WHERE MAHH='" + lo.Mahh + "'";
            conn.ExecuteNonQuery(sql);
        }
        public bool Kiemtrakey(string chuoi)
        {
            string sql = "Select * from HANGHOA where MAHH= '" + chuoi + "'";
            DataSet d = conn.getDuLieu(sql);
            if (d.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }
        public DataSet Search(String chuoi)
        {
            string sql = "Select * from HANGHOA where MAHH like '%" + chuoi + "%' or TENHH like '" + chuoi + "'";
            return conn.getDuLieu(sql);
        }
    }
}

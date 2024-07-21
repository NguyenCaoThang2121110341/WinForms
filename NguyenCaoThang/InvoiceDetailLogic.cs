using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class InvoiceDetailLogic
    {
        Connection conn = new Connection();
        InvoiceDetailObj rtobj = new InvoiceDetailObj();

        public DataSet getDataInvoiceDetail(InvoiceDetailObj lgo)
        {
            string sql = "select * from CHITIETHOADON where sohd = N'" + lgo.Sohd + "' and mahh = N'" + lgo.Mahh + "'and sl = N'" + lgo.Sl + "'";
            return conn.getDuLieu(sql);
        }
        public DataSet getDataInvoiceDetail()
        {
            string sql = "select * from CHITIETHOADON";
            return conn.getDuLieu(sql);
        }
        public void Themdl(InvoiceDetailObj lo)
        {
            string sql = "insert into CHITIETHOADON([SOHD],[MAHH],[SL]) values ('" + lo.Sohd + "','" + lo.Mahh + "','" + lo.Sl + "')";
            conn.ExecuteNonQuery(sql);
        }

        public void Xoadl(InvoiceDetailObj lo)
        {
            string sql = "delete from  where sohd = '" + lo.Sohd + "'";
            conn.ExecuteNonQuery(sql);
        }
        public void Suadl(InvoiceDetailObj lo)
        {
            string sql = "update CHITIETHOADON set sl='" + lo.Sl + "'where Sohd='" + lo.Sohd + "'";
            conn.ExecuteNonQuery(sql);
        }
        public bool Kiemtrakey(string chuoi)
        {
            string sql = "Select * from CHITIETHOADON where sohd= '" + chuoi + "'";
            DataSet d = conn.getDuLieu(sql);
            if (d.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }
        public DataSet Search(String chuoi)
        {
            string sql = "Select * from CHITIETHOADON where sohd like '%" + chuoi + "%' or MAHH like '" + chuoi + "'";
            return conn.getDuLieu(sql);
        }
    }
}

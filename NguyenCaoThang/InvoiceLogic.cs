using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class InvoiceLogic
    {
        Connection conn = new Connection();
        InvoiceObj rtobj = new InvoiceObj();

        public DataSet getDataInvoice(InvoiceObj lgo)
        {
            string sql = "select * from HOADON where sohd = N'" + lgo.Sohd + "' and manv = N'" + lgo.Manv + "'and ngaytao = N'" + lgo.Ngaytao + "'and kv = N'" + lgo.Kv + "'";
            return conn.getDuLieu(sql);
        }
        public DataSet getDataInvoice()
        {
            string sql = "select * from HOADON";
            return conn.getDuLieu(sql);
        }
        public void Themdl(InvoiceObj lo)
        {
            string sql = "insert into HOADON(SOHD,MANV,NGAYTAO,KV) values ('" + lo.Sohd + "','" + lo.Manv + "','" + lo.Ngaytao + "','" + lo.Kv + "')";
            conn.ExecuteNonQuery(sql);
        }

        public void Xoadl(InvoiceObj lo)
        {
            string sql = "delete from HOADON where sohd = '" + lo.Sohd + "'";
            conn.ExecuteNonQuery(sql);
        }
        public void Suadl(InvoiceObj lo)
        {
            string sql = "UPDATE HOADON set NGAYTAO=N'" + lo.Ngaytao + "', KV =N '" + lo.Kv + "'MANV =N '" + lo.Manv + "'where SOHD=N'" + lo.Sohd + "'";
            conn.ExecuteNonQuery(sql);
        }
        public bool Kiemtrakey(string chuoi)
        {
            string sql = "Select * from HOADON where sohd= '" + chuoi + "'";
            DataSet d = conn.getDuLieu(sql);
            if (d.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }
        public DataSet Search(String chuoi)
        {
            string sql = "Select * from HOADON where sohd like '%" + chuoi + "%' or MANV like '" + chuoi + "'";
            return conn.getDuLieu(sql);
        }
    }
}

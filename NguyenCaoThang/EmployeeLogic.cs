using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class EmployeeLogic
    {
        Connection conn = new Connection();
        EmployeeObj rtobj = new EmployeeObj();

        public DataSet getDataEmployee(EmployeeObj lgo)
        {
            string sql = "select * from NHANVIEN where manv = N'" + lgo.Manv + "' and tennv = N'" + lgo.Tennv + "'and diachi = N'" + lgo.Diachi + "'and tennv = N'" + lgo.Dienthoai + "'";
            return conn.getDuLieu(sql);
        }
        public DataSet getDataEmployee()
        {
            string sql = "select * from NHANVIEN";
            return conn.getDuLieu(sql);
        }
        public void Themdl(EmployeeObj lo)
        {
            string sql = "insert into NHANVIEN([MANV],[TENNV],[diachi],[DIENTHOAI]) values ('" + lo.Manv + "','" + lo.Tennv + "','" + lo.Diachi + "','" + lo.Dienthoai + "')";
            conn.ExecuteNonQuery(sql);
        }
   

        public void Xoadl(EmployeeObj lo)
        {
            string sql = "delete from NHANVIEN where manv = '" + lo.Manv + "'";
            conn.ExecuteNonQuery(sql);
        }
        public void Suadl(EmployeeObj lo)
        {
            string sql = "UPDATE NHANVIEN set TENNV='" + lo.Tennv + "', diachi = '" + lo.Diachi + "', DIENTHOAI = '" + lo.Dienthoai + "' WHERE MANV='" + lo.Manv + "'";
            conn.ExecuteNonQuery(sql);
        }
        public bool Kiemtrakey(string chuoi)
        {
            string sql = "Select * from NHANVIEN where manv= '" + chuoi + "'";
            DataSet d = conn.getDuLieu(sql);
            if (d.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }
        public DataSet Search(String chuoi)
        {
            string sql = "Select * from NHANVIEN where MANV like '%" + chuoi + "%' or tennv like '" + chuoi + "'";
            return conn.getDuLieu(sql);
        }
    }
}

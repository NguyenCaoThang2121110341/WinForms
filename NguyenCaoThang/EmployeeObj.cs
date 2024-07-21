using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class EmployeeObj
    {
        string manv, tennv, diachi, dienthoai;

        public EmployeeObj()
        {

        }

        public EmployeeObj(String u, String p, String a, String b )
        {
            manv = u;
            tennv = p;
            diachi = a;
            dienthoai = b;

        }


        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }

        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Dienthoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
    }
}

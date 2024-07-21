using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class InvoiceObj
    {
        string sohd, kv;
        object manv;
        DateTime ngaytao;

        public InvoiceObj()
        {
        }

        public InvoiceObj(string text)
        {

        }

        public InvoiceObj(String u, Object p, DateTime a, String b)
        {
            sohd = u;
            manv = p;
            ngaytao = a;
            kv = b;

        }


        public string Sohd
        {
            get { return sohd; }
            set { sohd = value; }
        }

        public object Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        public DateTime Ngaytao
        {
            get { return ngaytao; }
            set { ngaytao = value; }
        }
        public string Kv
        {
            get { return kv; }
            set { kv = value; }
        }
    }
}

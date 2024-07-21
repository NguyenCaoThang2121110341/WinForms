using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class InvoiceDetailObj
    {
        object sohd, mahh;
        string sl;

        public InvoiceDetailObj()
        {

        }

        public InvoiceDetailObj(object u, object p, String a)
        {
            sohd = u;
            mahh = p;
            sl = a;
        }


        public object Sohd
        {
            get { return sohd; }
            set { sohd = value; }
        }

        public object Mahh
        {
            get { return mahh; }
            set { mahh = value; }
        }
        public String Sl
        {
            get { return sl; }
            set { sl = value; }
        }
    }
}

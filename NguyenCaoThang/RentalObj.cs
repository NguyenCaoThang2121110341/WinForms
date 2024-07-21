using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class RentalObj
    {
        object manv, mahh;

        public RentalObj()
        {

        }

        public RentalObj(object u, object p)
        {
            manv = u;
            mahh = p;

        }


        public object Manv
        {
            get { return manv; }
            set { manv = value; }
        }

        public object Mahh
        {
            get { return mahh; }
            set { mahh = value; }
        }
    }
}

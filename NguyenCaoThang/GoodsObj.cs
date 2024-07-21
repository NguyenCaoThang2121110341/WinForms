using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class GoodsObj
    {
        string mahh, tenhh, donvi, dongia;

        public GoodsObj()
        {

        }

        public GoodsObj(String u, String p, String a, String b)
        {
            mahh = u;
            tenhh = p;
            donvi = a;
            dongia = b;

        }


        public string Mahh
        {
            get { return mahh; }
            set { mahh = value; }
        }

        public string Tenhh
        {
            get { return tenhh; }
            set { tenhh = value; }
        }
        public string Donvi
        {
            get { return donvi; }
            set { donvi = value; }
        }
        public string Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
    }
}

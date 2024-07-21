using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenCaoThang
{
    internal class LoginObj
    {
        string username, password;

        public LoginObj()
        {

        }

        public LoginObj(String u, String p)
        {
            username = u;
            password = p;

        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}

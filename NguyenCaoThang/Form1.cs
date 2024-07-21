using NguyenCaoThang;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NguyenCaoThang
{
    public partial class Login : Form
    {
        LoginLogic lg = new LoginLogic();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("") || txtPassword.Text.Equals(""))
                return;
            LoginObj lgob = new LoginObj(txtName.Text, txtPassword.Text);
            DataSet d = lg.getDataLogin(lgob);
            if (d.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Thanh cong");
                this.Close();
            }
            else
                MessageBox.Show("That bai");
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("") || txtPassword.Text.Equals(""))
                return;
            LoginObj lgob = new LoginObj(txtName.Text, txtPassword.Text);
            DataSet d = lg.getDataLogin(lgob);
            if (d.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Thanh cong");
                this.Close();
            }
            else
                MessageBox.Show("That bai");
        }
    }
}
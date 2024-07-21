using NguyenCaoThang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NguyenCaoThang
{
    public partial class Login_TSX : Form
    {
        DataSet dsLogin = new DataSet();
        LoginLogic lg = new LoginLogic();
        LoginObj LogObj = new LoginObj();
        bool flag = true;
        public Login_TSX()
        {
            InitializeComponent();
        }

        private void Login_TSX_Load(object sender, EventArgs e)
        {
            dsLogin = lg.getDataLogin();
            dgvLogin.DataSource = dsLogin.Tables[0];
            DieuKhien(true);
        }
        public void DieuKhien(bool b)
        {
            btnAdd.Enabled = b;
            btnDelete.Enabled = b;
            btnUpdate.Enabled = b;
            btnSave.Enabled = !b;
            btnSkip.Enabled = !b;

            txtName.ReadOnly = b;
            txtPass.ReadOnly = b;


        }
        public void XoaTextBox()
        {
            txtName.Text = string.Empty;
            txtPass.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = true;
            XoaTextBox();
            DieuKhien(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flag = false;
            DieuKhien(false);
            txtName.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LogObj.Username = txtName.Text;
            LogObj.Password = txtPass.Text;
            if (txtName.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                if (lg.Kiemtrakey(txtName.Text))
                {
                    MessageBox.Show(txtName.Text + " da ton tai");
                }
                else
                {
                    lg.Themdl(LogObj);
                    DataSet ds = lg.getDataLogin();
                    dgvLogin.DataSource = ds.Tables[0];
                    MessageBox.Show("Them thanh cong");

                }
            }
            else
            {

                lg.Suadl(LogObj);
                DataSet ds = lg.getDataLogin();
                dgvLogin.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon xoa khong?", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginObj lgo = new LoginObj(txtName.Text, txtPass.Text);
                lg.Xoadl(lgo);
                DataSet ds = lg.getDataLogin();
                dgvLogin.DataSource = ds.Tables[0];
                MessageBox.Show("Xoa thanh cong");
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            DieuKhien(true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvLogin_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvLogin.CurrentCell != null)
                {
                    int i = dgvLogin.CurrentCell.RowIndex;
                    txtName.Text = dgvLogin[0, i].Value.ToString();
                    txtPass.Text = dgvLogin[1, i].Value.ToString();
                }
            }
            catch { }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            flag = true;
            XoaTextBox();
            DieuKhien(false);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            flag = false;
            DieuKhien(false);
            txtName.ReadOnly = true;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon xoa khong?", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginObj lgo = new LoginObj(txtName.Text, txtPass.Text);
                lg.Xoadl(lgo);
                DataSet ds = lg.getDataLogin();
                dgvLogin.DataSource = ds.Tables[0];
                MessageBox.Show("Xoa thanh cong");
            }
        }

        private void btnSkip_Click_1(object sender, EventArgs e)
        {
            XoaTextBox();
            DieuKhien(true);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            LogObj.Username = txtName.Text;
            LogObj.Password = txtPass.Text;
            if (txtName.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                if (lg.Kiemtrakey(txtName.Text))
                {
                    MessageBox.Show(txtName.Text + " da ton tai");
                }
                else
                {
                    lg.Themdl(LogObj);
                    DataSet ds = lg.getDataLogin();
                    dgvLogin.DataSource = ds.Tables[0];
                    MessageBox.Show("Them thanh cong");

                }
            }
            else
            {

                lg.Suadl(LogObj);
                DataSet ds = lg.getDataLogin();
                dgvLogin.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvLogin_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvLogin.CurrentCell != null)
                {
                    int i = dgvLogin.CurrentCell.RowIndex;
                    txtName.Text = dgvLogin[0, i].Value.ToString();
                    txtPass.Text = dgvLogin[1, i].Value.ToString();
                }
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = lg.Search(txtSearch.Text);
            dgvLogin.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginReportcs loginReportcs = new LoginReportcs();
            loginReportcs.Show();
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NguyenCaoThang
{
    public partial class Rental : Form
    {
        DataSet dsRental = new DataSet();
        bool flag = true;
        RentalObj LogObj = new RentalObj();
        RentalLogic rt = new RentalLogic();

        GoodsLogic go = new GoodsLogic();
        EmployeeLogic emp = new EmployeeLogic();

        public Rental()
        {
            InitializeComponent();
        }

        private void Rental_Load(object sender, EventArgs e)
        {
            dsRental = rt.getDataRental();
            dgvRental.DataSource = dsRental.Tables[0];
            DataSet dsg = go.getDataGoods();
            cboMAHH.DataSource = dsg.Tables[0];
            DataSet dsem = emp.getDataEmployee();
            cboMANV.DataSource = dsem.Tables[0];
            cboMAHH.DisplayMember = "mahh";
            cboMANV.ValueMember = "manv";
            cboMAHH.DisplayMember = "mahh";
            cboMANV.ValueMember = "manv";

            DieuKhien(true);
        }
        void DieuKhien(bool b)
        {
            btnAdd.Enabled = b;
            btnUpdate.Enabled = b;
            btnSkip.Enabled = !b;
            btnDelete.Enabled = b;
            btnSave.Enabled = !b;
            dgvRental.Enabled = b;

            cboMAHH.Enabled = !b;
            cboMANV.Enabled = !b;

        }
        public void XoaTextBox()
        {
            cboMANV.Text = string.Empty;
            cboMAHH.Text = string.Empty;
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


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RentalObj lgo = new RentalObj(cboMANV.Text, cboMAHH.Text);
            rt.Xoadl(lgo);
            DataSet dsLogin = rt.getDataRental();
            dgvRental.DataSource = dsLogin.Tables[0];
            MessageBox.Show("Xoa thanh cong");
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            DieuKhien(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cboMANV.Text.Equals("") || cboMAHH.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                RentalObj lgo = new RentalObj(cboMANV.Text, cboMAHH.Text);
                rt.Themdl(lgo);
                DataSet ds = rt.getDataRental();
                dgvRental.DataSource = ds.Tables[0];
                MessageBox.Show("Them thanh cong");


            }
            else
            {
                RentalObj lgo = new RentalObj(cboMANV.Text, cboMAHH.Text);
                rt.Suadl(lgo);
                DataSet ds = rt.getDataRental();
                dgvRental.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvRental_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvRental.CurrentCell != null)
                {
                    int i = dgvRental.CurrentCell.RowIndex;
                    cboMANV.Text = dgvRental[0, i].Value.ToString();
                    cboMAHH.Text = dgvRental[1, i].Value.ToString();
                }
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = rt.Search(txtSearch.Text);
            dgvRental.DataSource = ds.Tables[0];
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
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            RentalObj lgo = new RentalObj(cboMANV.Text, cboMAHH.Text);
            rt.Xoadl(lgo);
            DataSet dsLogin = rt.getDataRental();
            dgvRental.DataSource = dsLogin.Tables[0];
            MessageBox.Show("Xoa thanh cong");
        }

        private void btnSkip_Click_1(object sender, EventArgs e)
        {
            XoaTextBox();
            DieuKhien(true);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cboMANV.Text.Equals("") || cboMAHH.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                RentalObj lgo = new RentalObj(cboMANV.Text, cboMAHH.Text);
                rt.Themdl(lgo);
                DataSet ds = rt.getDataRental();
                dgvRental.DataSource = ds.Tables[0];
                MessageBox.Show("Them thanh cong");


            }
            else
            {
                RentalObj lgo = new RentalObj(cboMANV.Text, cboMAHH.Text);
                rt.Suadl(lgo);
                DataSet ds = rt.getDataRental();
                dgvRental.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvRental_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvRental.CurrentCell != null)
                {
                    int i = dgvRental.CurrentCell.RowIndex;
                    cboMANV.Text = dgvRental[0, i].Value.ToString();
                    cboMAHH.Text = dgvRental[1, i].Value.ToString();
                }
            }
            catch { }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DataSet ds = rt.Search(txtSearch.Text);
            dgvRental.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentalReport rentalReport = new RentalReport();
            rentalReport.ShowDialog();
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NguyenCaoThang
{
    public partial class Employee : Form
    {

        DataSet dsEmployee = new DataSet();
        bool flag = true;
        EmployeeObj empObj = new EmployeeObj();
        EmployeeLogic el = new EmployeeLogic();
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            dsEmployee = el.getDataEmployee();
            dgvEmployee.DataSource = dsEmployee.Tables[0];
            DieuKhien(true);
        }
        void DieuKhien(bool b)
        {
            btnAdd.Enabled = b;
            btnUpdate.Enabled = b;
            btnSkip.Enabled = !b;
            btnDelete.Enabled = b;
            btnSave.Enabled = !b;
            dgvEmployee.Enabled = b;

        }
        public void XoaTextBox()
        {
            txtMANV.Text = string.Empty;
            txtTENNV.Text = string.Empty;
            txtDC.Text = string.Empty;
            txtDT.Text = string.Empty;
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
            EmployeeObj lgo = new EmployeeObj(txtMANV.Text, txtTENNV.Text, txtDC.Text, txtDT.Text);
            el.Xoadl(lgo);
            DataSet dsLogin = el.getDataEmployee();
            dgvEmployee.DataSource = dsLogin.Tables[0];
            MessageBox.Show("Xoa thanh cong");
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            DieuKhien(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            empObj.Manv = txtMANV.Text;
            empObj.Tennv = txtTENNV.Text;
            empObj.Diachi = txtDC.Text;
            empObj.Dienthoai = txtDT.Text;
            if (txtMANV.Text.Equals("") || txtTENNV.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                if (el.Kiemtrakey(txtMANV.Text))
                {
                    MessageBox.Show(txtMANV.Text + " da ton tai");
                }
                else
                {
                    el.Themdl(empObj);
                    DataSet ds = el.getDataEmployee();
                    dgvEmployee.DataSource = ds.Tables[0];
                    MessageBox.Show("Them thanh cong");

                }
            }
            else
            {
                EmployeeObj lgo = new EmployeeObj(txtMANV.Text, txtTENNV.Text, txtDC.Text, txtDT.Text);
                el.Suadl(lgo);
                DataSet ds = el.getDataEmployee();
                dgvEmployee.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvEmployee_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployee.CurrentCell != null)
                {
                    int i = dgvEmployee.CurrentCell.RowIndex;
                    txtMANV.Text = dgvEmployee[0, i].Value.ToString();
                    txtTENNV.Text = dgvEmployee[1, i].Value.ToString();
                    txtDC.Text = dgvEmployee[2, i].Value.ToString();
                    txtDT.Text = dgvEmployee[3, i].Value.ToString();
                }
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = el.Search(txtSearch.Text);
            dgvEmployee.DataSource = ds.Tables[0];
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

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
            EmployeeObj lgo = new EmployeeObj(txtMANV.Text, txtTENNV.Text, txtDC.Text, txtDT.Text);
            el.Xoadl(lgo);
            DataSet dsLogin = el.getDataEmployee();
            dgvEmployee.DataSource = dsLogin.Tables[0];
            MessageBox.Show("Xoa thanh cong");
        }

        private void btnSkip_Click_1(object sender, EventArgs e)
        {
            XoaTextBox();
            DieuKhien(true);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            empObj.Manv = txtMANV.Text;
            empObj.Tennv = txtTENNV.Text;
            empObj.Diachi = txtDC.Text;
            empObj.Dienthoai = txtDT.Text;
            if (txtMANV.Text.Equals("") || txtTENNV.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                if (el.Kiemtrakey(txtMANV.Text))
                {
                    MessageBox.Show(txtMANV.Text + " da ton tai");
                }
                else
                {
                    el.Themdl(empObj);
                    DataSet ds = el.getDataEmployee();
                    dgvEmployee.DataSource = ds.Tables[0];
                    MessageBox.Show("Them thanh cong");

                }
            }
            else
            {
                EmployeeObj lgo = new EmployeeObj(txtMANV.Text, txtTENNV.Text, txtDC.Text, txtDT.Text);
                el.Suadl(lgo);
                DataSet ds = el.getDataEmployee();
                dgvEmployee.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DataSet ds = el.Search(txtSearch.Text);
            dgvEmployee.DataSource = ds.Tables[0];
        }

        private void dgvEmployee_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployee.CurrentCell != null)
                {
                    int i = dgvEmployee.CurrentCell.RowIndex;
                    txtMANV.Text = dgvEmployee[0, i].Value.ToString();
                    txtTENNV.Text = dgvEmployee[1, i].Value.ToString();
                    txtDC.Text = dgvEmployee[2, i].Value.ToString();
                    txtDT.Text = dgvEmployee[3, i].Value.ToString();
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form_Employee_Report form_Employee_Report = new Form_Employee_Report();
            //   form_Employee_Report.ShowDialog();

            EmployeeReport employeeReport = new EmployeeReport();
            employeeReport.Show();
        }

       
    }
}

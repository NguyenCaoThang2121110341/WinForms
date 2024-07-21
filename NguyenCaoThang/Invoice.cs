
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

namespace NguyenCaoThang
{
    public partial class Invoice : Form
    {
        DataSet dsInvoice = new DataSet();
        bool flag = true;
        InvoiceObj ivObj = new InvoiceObj();
        InvoiceLogic iv = new InvoiceLogic();

        EmployeeLogic emp = new EmployeeLogic();
        public Invoice()
        {
            InitializeComponent();
        }
        void Xoadl()
        {
            txtSOHD.Text = string.Empty;

            txtNT.Format = DateTimePickerFormat.Custom;
            txtNT.CustomFormat = "MM/dd/yyyy";
            txtNT.ShowUpDown = false; // Không hiển thị nút up-down
            txtNT.Value = DateTime.Now.Date;

        }

        private void Invoice_Load(object sender, EventArgs e)
        {

            dsInvoice = iv.getDataInvoice();
            dgvInvoice.DataSource = dsInvoice.Tables[0];
            DataSet dsnv = emp.getDataEmployee();
            cboMANV.DataSource = dsnv.Tables[0];
            cboMANV.DisplayMember = "manv";
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
            dgvInvoice.Enabled = b;

            txtSOHD.ReadOnly = b;
            txtNT.Enabled = !b;
            cboMANV.Enabled = !b;

        }
        public void XoaTextBox()
        {
            cboMANV.Text = string.Empty;
            txtSOHD.Text = string.Empty;
            txtKV.Text = string.Empty;
            txtNT.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = true;
            Xoadl();
            DieuKhien(false);
            cboMANV.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flag = false;
            DieuKhien(false);
            txtSOHD.ReadOnly = true;
            cboMANV.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            InvoiceObj lgo = new InvoiceObj(txtSOHD.Text, cboMANV.Text, txtNT.Value, txtKV.Text);
            iv.Xoadl(lgo);
            DataSet dsLogin = iv.getDataInvoice();
            dgvInvoice.DataSource = dsLogin.Tables[0];
            MessageBox.Show("Xoa thanh cong");
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Xoadl();
            DieuKhien(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ivObj.Sohd = txtSOHD.Text;
            //ivObj.Manv = cboMANV.Text;
            //ivObj.Ngaytao = txtNT.Text;
            //ivObj.Kv = txtKV.Text;
            if (cboMANV.Text.Equals("") || txtSOHD.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                txtNT.Value = DateTime.Now.Date;
                if (iv.Kiemtrakey(txtSOHD.Text))
                {
                    MessageBox.Show(txtSOHD.Text + " da ton tai");
                }
                else
                {
                    InvoiceObj lgo = new InvoiceObj(txtSOHD.Text, cboMANV.SelectedValue, txtNT.Value, txtKV.Text);
                    iv.Themdl(lgo);
                    DataSet ds = iv.getDataInvoice();
                    dgvInvoice.DataSource = ds.Tables[0];
                    MessageBox.Show("Them thanh cong");

                }
            }
            else
            {
                InvoiceObj lgo = new InvoiceObj(txtSOHD.Text, cboMANV.SelectedValue, txtNT.Value, txtKV.Text);
                iv.Suadl(lgo);
                DataSet ds = iv.getDataInvoice();
                dgvInvoice.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvInvoice_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoice.CurrentCell != null)
                {
                    int i = dgvInvoice.CurrentCell.RowIndex;
                    txtSOHD.Text = dgvInvoice[0, i].Value.ToString();
                    string manv = dgvInvoice[1, i].Value.ToString();
                    DateTime txtNTValue;
                    if (DateTime.TryParse(dgvInvoice[2, i].Value.ToString(), out txtNTValue))
                    {
                        txtNT.Format = DateTimePickerFormat.Custom;
                        txtNT.CustomFormat = "MM/dd/yyyy";
                        txtNT.ShowUpDown = false;
                        txtNT.Value = txtNTValue;
                    }
                    txtKV.Text = dgvInvoice[3, i].Value.ToString();
                    DataSet dsnv = emp.getDataEmployee();
                    if (dsnv != null && dsnv.Tables.Count > 0)
                    {
                        DataTable NhanVienData = dsnv.Tables[0];
                        DataRow[] rows = NhanVienData.Select("manv = '" + manv + "'");
                        if (rows.Length > 0)
                        {
                            string Manv = rows[0]["manv"].ToString();
                            cboMANV.DisplayMember = "manv";
                            cboMANV.ValueMember = "manv";

                            // Gán tên khách hàng cho DisplayMember và giá trị makh cho SelectedValue
                            cboMANV.DisplayMember = Manv;
                            cboMANV.SelectedValue = Manv;
                        }
                    }
                }
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = iv.Search(txtSearch.Text);
            dgvInvoice.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            flag = true;
            Xoadl();
            DieuKhien(false);
            cboMANV.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            flag = false;
            DieuKhien(false);
            txtSOHD.ReadOnly = true;
            cboMANV.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            InvoiceObj lgo = new InvoiceObj(txtSOHD.Text, cboMANV.Text, txtNT.Value, txtKV.Text);
            iv.Xoadl(lgo);
            DataSet dsLogin = iv.getDataInvoice();
            dgvInvoice.DataSource = dsLogin.Tables[0];
            MessageBox.Show("Xoa thanh cong");
        }

        private void btnSkip_Click_1(object sender, EventArgs e)
        {
            Xoadl();
            DieuKhien(true);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cboMANV.Text.Equals("") || txtSOHD.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                txtNT.Value = DateTime.Now.Date;
                if (iv.Kiemtrakey(txtSOHD.Text))
                {
                    MessageBox.Show(txtSOHD.Text + " da ton tai");
                }
                else
                {
                    InvoiceObj lgo = new InvoiceObj(txtSOHD.Text, cboMANV.SelectedValue, txtNT.Value, txtKV.Text);
                    iv.Themdl(lgo);
                    DataSet ds = iv.getDataInvoice();
                    dgvInvoice.DataSource = ds.Tables[0];
                    MessageBox.Show("Them thanh cong");

                }
            }
            else
            {
                InvoiceObj lgo = new InvoiceObj(txtSOHD.Text, cboMANV.SelectedValue, txtNT.Value, txtKV.Text);
                iv.Suadl(lgo);
                DataSet ds = iv.getDataInvoice();
                dgvInvoice.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvInvoice_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoice.CurrentCell != null)
                {
                    int i = dgvInvoice.CurrentCell.RowIndex;
                    txtSOHD.Text = dgvInvoice[0, i].Value.ToString();
                    string manv = dgvInvoice[1, i].Value.ToString();
                    DateTime txtNTValue;
                    if (DateTime.TryParse(dgvInvoice[2, i].Value.ToString(), out txtNTValue))
                    {
                        txtNT.Format = DateTimePickerFormat.Custom;
                        txtNT.CustomFormat = "MM/dd/yyyy";
                        txtNT.ShowUpDown = false;
                        txtNT.Value = txtNTValue;
                    }
                    txtKV.Text = dgvInvoice[3, i].Value.ToString();
                    DataSet dsnv = emp.getDataEmployee();
                    if (dsnv != null && dsnv.Tables.Count > 0)
                    {
                        DataTable NhanVienData = dsnv.Tables[0];
                        DataRow[] rows = NhanVienData.Select("manv = '" + manv + "'");
                        if (rows.Length > 0)
                        {
                            string Manv = rows[0]["manv"].ToString();
                            cboMANV.DisplayMember = "manv";
                            cboMANV.ValueMember = "manv";

                            // Gán tên khách hàng cho DisplayMember và giá trị makh cho SelectedValue
                            cboMANV.DisplayMember = Manv;
                            cboMANV.SelectedValue = Manv;
                        }
                    }
                }
            }
            catch { }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DataSet ds = iv.Search(txtSearch.Text);
            dgvInvoice.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceReport invoiceReport = new InvoiceReport();  
            invoiceReport.ShowDialog();
        }
    }
}

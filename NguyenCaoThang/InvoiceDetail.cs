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
    public partial class InvoiceDetail : Form
    {
        DataSet dsID = new DataSet();
        bool flag = true;
        InvoiceDetailObj idObj = new InvoiceDetailObj();
        InvoiceDetailLogic id = new InvoiceDetailLogic();

        GoodsLogic go = new GoodsLogic();
        InvoiceLogic iv = new InvoiceLogic();
        public InvoiceDetail()
        {
            InitializeComponent();
        }

        private void InvoiceDetail_Load(object sender, EventArgs e)
        {
            dsID = id.getDataInvoiceDetail();
            dgvID.DataSource = dsID.Tables[0];
            DataSet dsg = go.getDataGoods();
            cboMAHH.DataSource = dsg.Tables[0];
            DataSet dsiv = iv.getDataInvoice();
            cboSOHD.DataSource = dsiv.Tables[0];
            cboMAHH.DisplayMember = "mahh";
            cboSOHD.ValueMember = "sohd";
            cboMAHH.DisplayMember = "mahh";
            cboSOHD.ValueMember = "sohd";
            DieuKhien(true);
        }
        void DieuKhien(bool b)
        {
            btnAdd.Enabled = b;
            btnUpdate.Enabled = b;
            btnSkip.Enabled = !b;
            btnDelete.Enabled = b;
            btnSave.Enabled = !b;
            dgvID.Enabled = b;

            cboSOHD.Enabled = !b;
            cboMAHH.Enabled = !b;

        }
        public void XoaTextBox()
        {
            cboSOHD.Text = string.Empty;
            cboMAHH.Text = string.Empty;
            txtSL.Text = string.Empty;
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
            InvoiceDetailObj lgo = new InvoiceDetailObj(cboSOHD.Text, cboMAHH.Text, txtSL.Text);
            id.Xoadl(lgo);
            DataSet dsLogin = id.getDataInvoiceDetail();
            dgvID.DataSource = dsLogin.Tables[0];
            MessageBox.Show("Xoa thanh cong");
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            DieuKhien(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboSOHD.Text.Equals("") || cboMAHH.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                InvoiceDetailObj lgo = new InvoiceDetailObj(cboSOHD.Text, cboMAHH.Text, txtSL.Text);
                id.Themdl(lgo);
                DataSet ds = id.getDataInvoiceDetail();
                dgvID.DataSource = ds.Tables[0];
                MessageBox.Show("Them thanh cong");


            }
            else
            {

                InvoiceDetailObj lgo = new InvoiceDetailObj(cboSOHD.Text, cboMAHH.Text, txtSL.Text);
                id.Suadl(lgo);
                DataSet ds = id.getDataInvoiceDetail();

                dgvID.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvID_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvID.CurrentCell != null)
                {
                    int i = dgvID.CurrentCell.RowIndex;
                    cboSOHD.Text = dgvID[0, i].Value.ToString();
                    cboMAHH.Text = dgvID[1, i].Value.ToString();
                    txtSL.Text = dgvID[2, i].Value.ToString();
                }
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = id.Search(txtSearch.Text);
            dgvID.DataSource = ds.Tables[0];
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
            InvoiceDetailObj lgo = new InvoiceDetailObj(cboSOHD.Text, cboMAHH.Text, txtSL.Text);
            id.Xoadl(lgo);
            DataSet dsLogin = id.getDataInvoiceDetail();
            dgvID.DataSource = dsLogin.Tables[0];
            MessageBox.Show("Xoa thanh cong");
        }

        private void btnSkip_Click_1(object sender, EventArgs e)
        {
            XoaTextBox();
            DieuKhien(true);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cboSOHD.Text.Equals("") || cboMAHH.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                InvoiceDetailObj lgo = new InvoiceDetailObj(cboSOHD.Text, cboMAHH.Text, txtSL.Text);
                id.Themdl(lgo);
                DataSet ds = id.getDataInvoiceDetail();
                dgvID.DataSource = ds.Tables[0];
                MessageBox.Show("Them thanh cong");


            }
            else
            {

                InvoiceDetailObj lgo = new InvoiceDetailObj(cboSOHD.Text, cboMAHH.Text, txtSL.Text);
                id.Suadl(lgo);
                DataSet ds = id.getDataInvoiceDetail();

                dgvID.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvID_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvID.CurrentCell != null)
                {
                    int i = dgvID.CurrentCell.RowIndex;
                    cboSOHD.Text = dgvID[0, i].Value.ToString();
                    cboMAHH.Text = dgvID[1, i].Value.ToString();
                    txtSL.Text = dgvID[2, i].Value.ToString();
                }
            }
            catch { }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DataSet ds = iv.Search(txtSearch.Text);
            dgvID.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDReport iDReport = new IDReport();
            iDReport.ShowDialog();
        }
    }
}

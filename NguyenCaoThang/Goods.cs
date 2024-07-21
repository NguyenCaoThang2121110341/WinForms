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
    public partial class Goods : Form
    {
        DataSet dsGoods = new DataSet();
        bool flag = true;
        GoodsObj gObj = new GoodsObj();
        GoodsLogic g = new GoodsLogic();
        public Goods()
        {
            InitializeComponent();
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            dsGoods = g.getDataGoods();
            dgvGoods.DataSource = dsGoods.Tables[0];
            DieuKhien(true);
        }
        void DieuKhien(bool b)
        {
            btnAdd.Enabled = b;
            btnUpdate.Enabled = b;
            btnSkip.Enabled = !b;
            btnDelete.Enabled = b;
            btnSave.Enabled = !b;
            dgvGoods.Enabled = b;
            txtMAHH.ReadOnly = b;
            txtTENHH.ReadOnly = b;
            txtDV.ReadOnly = b;
            txtDG.ReadOnly = b;

        }
        public void XoaTextBox()
        {
            txtMAHH.Text = string.Empty;
            txtTENHH.Text = string.Empty;
            txtDV.Text = string.Empty;
            txtDG.Text = string.Empty;
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
            txtMAHH.ReadOnly = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GoodsObj lgo = new GoodsObj(txtMAHH.Text, txtTENHH.Text, txtDV.Text, txtDG.Text);
            g.Xoadl(lgo);
            DataSet dsGoods = g.getDataGoods();
            dgvGoods.DataSource = dsGoods.Tables[0];
            MessageBox.Show("Xoa thanh cong");
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            DieuKhien(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gObj.Mahh = txtMAHH.Text;
            gObj.Tenhh = txtTENHH.Text;
            gObj.Donvi = txtDV.Text;
            gObj.Dongia = txtDG.Text;
            if (txtMAHH.Text.Equals("") || txtTENHH.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                if (g.Kiemtrakey(txtMAHH.Text))
                {
                    MessageBox.Show(txtMAHH.Text + " da ton tai");
                }
                else
                {
                    g.Themdl(gObj);
                    DataSet ds = g.getDataGoods();
                    dgvGoods.DataSource = ds.Tables[0];
                    MessageBox.Show("Them thanh cong");

                }
            }
            else
            {
                GoodsObj lgo = new GoodsObj(txtMAHH.Text, txtTENHH.Text, txtDV.Text, txtDG.Text);
                g.Suadl(lgo);
                DataSet ds = g.getDataGoods();
                dgvGoods.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvGoods_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvGoods.CurrentCell != null)
                {
                    int i = dgvGoods.CurrentCell.RowIndex;
                    txtMAHH.Text = dgvGoods[0, i].Value.ToString();
                    txtTENHH.Text = dgvGoods[1, i].Value.ToString();
                    txtDV.Text = dgvGoods[2, i].Value.ToString();
                    txtDG.Text = dgvGoods[3, i].Value.ToString();
                }
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = g.Search(txtSearch.Text);
            dgvGoods.DataSource = ds.Tables[0];
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
            txtMAHH.ReadOnly = true;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            GoodsObj lgo = new GoodsObj(txtMAHH.Text, txtTENHH.Text, txtDV.Text, txtDG.Text);
            g.Xoadl(lgo);
            DataSet dsGoods = g.getDataGoods();
            dgvGoods.DataSource = dsGoods.Tables[0];
            MessageBox.Show("Xoa thanh cong");
        }

        private void btnSkip_Click_1(object sender, EventArgs e)
        {
            XoaTextBox();
            DieuKhien(true);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            gObj.Mahh = txtMAHH.Text;
            gObj.Tenhh = txtTENHH.Text;
            gObj.Donvi = txtDV.Text;
            gObj.Dongia = txtDG.Text;
            if (txtMAHH.Text.Equals("") || txtTENHH.Text.Equals(""))
            {
                MessageBox.Show("Nhap day du thon tin");
            }
            if (flag)
            {
                if (g.Kiemtrakey(txtMAHH.Text))
                {
                    MessageBox.Show(txtMAHH.Text + " da ton tai");
                }
                else
                {
                    g.Themdl(gObj);
                    DataSet ds = g.getDataGoods();
                    dgvGoods.DataSource = ds.Tables[0];
                    MessageBox.Show("Them thanh cong");

                }
            }
            else
            {
                GoodsObj lgo = new GoodsObj(txtMAHH.Text, txtTENHH.Text, txtDV.Text, txtDG.Text);
                g.Suadl(lgo);
                DataSet ds = g.getDataGoods();
                dgvGoods.DataSource = ds.Tables[0];
                MessageBox.Show("Sua thanh cong");
            }
            DieuKhien(true);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvGoods_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvGoods.CurrentCell != null)
                {
                    int i = dgvGoods.CurrentCell.RowIndex;
                    txtMAHH.Text = dgvGoods[0, i].Value.ToString();
                    txtTENHH.Text = dgvGoods[1, i].Value.ToString();
                    txtDV.Text = dgvGoods[2, i].Value.ToString();
                    txtDG.Text = dgvGoods[3, i].Value.ToString();
                }
            }
            catch { }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DataSet ds = g.Search(txtSearch.Text);
            dgvGoods.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoodsReport goodsReportcs = new GoodsReport();
            goodsReportcs.Show();
        }
    }
}

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
    public partial class InvoiceReport : Form
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }

        private void InvoiceReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNV_THUEHANGHOADataSet.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qLNV_THUEHANGHOADataSet.HOADON);

            this.reportViewer1.RefreshReport();
        }
    }
}

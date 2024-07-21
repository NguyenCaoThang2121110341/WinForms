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
    public partial class IDReport : Form
    {
        public IDReport()
        {
            InitializeComponent();
        }

        private void IDReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNV_THUEHANGHOADataSet.CHITIETHOADON' table. You can move, or remove it, as needed.
            this.cHITIETHOADONTableAdapter.Fill(this.qLNV_THUEHANGHOADataSet.CHITIETHOADON);

            this.reportViewer1.RefreshReport();
        }
    }
}

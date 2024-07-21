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
    public partial class RentalReport : Form
    {
        public RentalReport()
        {
            InitializeComponent();
        }

        private void RentalReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNV_THUEHANGHOADataSet.THUEHANGHOA' table. You can move, or remove it, as needed.
            this.tHUEHANGHOATableAdapter.Fill(this.qLNV_THUEHANGHOADataSet.THUEHANGHOA);

            this.reportViewer1.RefreshReport();
        }
    }
}

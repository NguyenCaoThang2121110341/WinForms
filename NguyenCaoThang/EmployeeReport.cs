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
    public partial class EmployeeReport : Form
    {
        public EmployeeReport()
        {
            InitializeComponent();
        }

        private void EmployeeReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNV_THUEHANGHOADataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLNV_THUEHANGHOADataSet.NHANVIEN);

            this.reportViewer1.RefreshReport();
        }
    }
}

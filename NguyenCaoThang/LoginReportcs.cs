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
    public partial class LoginReportcs : Form
    {
        public LoginReportcs()
        {
            InitializeComponent();
        }

        private void LoginReportcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNV_THUEHANGHOADataSet.LOGIN' table. You can move, or remove it, as needed.
            this.lOGINTableAdapter.Fill(this.qLNV_THUEHANGHOADataSet.LOGIN);

            this.reportViewer1.RefreshReport();
        }
    }
}

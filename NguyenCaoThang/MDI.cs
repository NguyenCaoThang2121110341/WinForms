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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            openChildForm(new Rental());
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Login_TSX());
            label1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Invoice());
            label1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            openChildForm(new InvoiceDetail());
            label1.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Goods());
            label1.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            openChildForm(new Employee());
            label1.Text = button6.Text;
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            Login login = new Login();

            login.ShowDialog();
        }

        private void button_thongke_Click(object sender, EventArgs e)
        {
            //Form2 form = new Form2();
            //form.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

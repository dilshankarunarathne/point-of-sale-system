using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_system
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }
        private Form activeForm;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Categories_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Categories());
        }

        private void Billing_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new billing());
        }

        private void Item_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Item());
        }
    }
}

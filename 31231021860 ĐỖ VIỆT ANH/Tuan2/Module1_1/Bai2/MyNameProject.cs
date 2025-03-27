using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmBaiTap1 : Form
    {
        public frmBaiTap1()
        {
            InitializeComponent();
        }

        private void frmBaiTap1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you really want to close?", "Exit",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter Your Name");
            else
                this.errorProvider1.Clear();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "This is not a valid number");
            else
                this.errorProvider1.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;
            string name;
            name = "My Name is: " + txtYourName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text); //Current Year - Enter year
            name = name + "Age: " + age.ToString();
            MessageBox.Show(name);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear text
            txtYourName.Clear();
            txtYear.Clear();
            //TextBox Your Name reset focus
            txtYourName.Focus(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtYourName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class frmLight : Form
    {
        public frmLight()
        {
            InitializeComponent();
        }

        private void frmLight_Load(object sender, EventArgs e)
        {
            
            this.StartPosition = FormStartPosition.CenterScreen;

            
            txtName.Text = "Jack";

           
            picTurnOn.Visible = true;
            picTurnOff.Visible = false;

            
            toolTip1.SetToolTip(picTurnOn, "Click me to Turn OFF the Light!");
            toolTip1.SetToolTip(picTurnOff, "Click me to Turn ON the Light!");

            
            lblHienThi.Text = txtName.Text + " Turn Off the Light, please!";
        }

        private void picTurnOn_Click(object sender, EventArgs e)
        {
            
            picTurnOn.Visible = false;
            picTurnOff.Visible = true;

            
            lblHienThi.Text = txtName.Text + " Turn On the Light, please!";
        }

        private void picTurnOff_Click(object sender, EventArgs e)
        {
            
            picTurnOff.Visible = false;
            picTurnOn.Visible = true;

           
            lblHienThi.Text = txtName.Text + " Turn Off the Light, please!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
            if (picTurnOn.Visible)
            {
                lblHienThi.Text = txtName.Text + " Turn Off the Light, please!";
            }
            else
            {
                lblHienThi.Text = txtName.Text + " Turn On the Light, please!";
            }
        }
    }
}

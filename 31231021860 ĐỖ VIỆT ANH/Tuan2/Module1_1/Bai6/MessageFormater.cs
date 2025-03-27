using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai6
{
    public partial class frmMessageFormater : Form
    {
        public frmMessageFormater()
        {
            InitializeComponent();

            this.AcceptButton = btnDisplay;

            this.CancelButton = btnExit;

            radRed.CheckedChanged += new EventHandler(radColor_CheckedChanged);
            radGreen.CheckedChanged += new EventHandler(radColor_CheckedChanged);
            radBlue.CheckedChanged += new EventHandler(radColor_CheckedChanged);
            radBlack.CheckedChanged += new EventHandler(radColor_CheckedChanged);

        }

        private void frmMessageFormater_Load(object sender, EventArgs e)
        {

            txtName.Focus();


            picSmall.Visible = false;


            toolTip1.SetToolTip(picBig, "Click Me");
            toolTip1.SetToolTip(picSmall, "Click Me");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + " : " + txtMessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtName.Clear();
            txtMessage.Clear();


            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    lblMessage.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    lblMessage.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    lblMessage.ForeColor = Color.Blue;
                    break;
                case "radBlack":
                    lblMessage.ForeColor = Color.Black;
                    break;
            }
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisible.Checked;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picSmall.Visible = false;
            picBig.Visible = true;
        }

        
    }
}

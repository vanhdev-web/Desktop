using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
{
    public partial class frmFont : Form
    {
        public frmFont()
        {
            InitializeComponent();
        }

        private void frmFont_Load(object sender, EventArgs e)
        {
            
            txtVanBan.Font = new Font("Tahoma", 20, FontStyle.Regular);          
            radTahoma.Checked = true;
        }

        private void radTimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimesNewRoman.Checked)
            { 
               txtVanBan.Font = new Font("Times New Roman", 20, txtVanBan.Font.Style);
            }
        }

        private void radArial_CheckedChanged(object sender, EventArgs e)
        {
            if (radArial.Checked)
            {
                txtVanBan.Font = new Font("Arial", 20, txtVanBan.Font.Style);
            }
        }

        private void radTahoma_CheckedChanged(object sender, EventArgs e)
        {
            if (radTahoma.Checked)
            {               
                txtVanBan.Font = new Font("Tahoma", 20, txtVanBan.Font.Style);
            }
        }

        private void radCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radCourierNew.Checked)
            {             
                txtVanBan.Font = new Font("Courier New", 20, txtVanBan.Font.Style);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class frmDinhDang : Form
    {
        public frmDinhDang()
        {
            InitializeComponent();

            this.CancelButton = btnThoat;

            radRed.CheckedChanged += radColor_CheckedChanged;
            radGreen.CheckedChanged += radColor_CheckedChanged;
            radBlue.CheckedChanged += radColor_CheckedChanged;
            radBlack.CheckedChanged += radColor_CheckedChanged;
        }

        private void frmDinhDang_Load(object sender, EventArgs e)
        {
           
            radRed.Checked = true;
           
            txtNhapTen.Focus();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }
        private void radColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    lblLapTrinh.ForeColor = Color.Red;
                    txtNhapTen.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    lblLapTrinh.ForeColor = Color.Green;
                    txtNhapTen.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    lblLapTrinh.ForeColor = Color.Blue;
                    txtNhapTen.ForeColor = Color.Blue;
                    break;
                case "radBlack":
                    lblLapTrinh.ForeColor = Color.Black;
                    txtNhapTen.ForeColor = Color.Black;
                    break;
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
                              lblLapTrinh.Font.Size,
                              lblLapTrinh.Font.Style ^ FontStyle.Bold);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name,
                                      txtNhapTen.Font.Size,
                                      txtNhapTen.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
                               lblLapTrinh.Font.Size,
                               lblLapTrinh.Font.Style ^ FontStyle.Italic);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name,
                                      txtNhapTen.Font.Size,
                                      txtNhapTen.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
                              lblLapTrinh.Font.Size,
                              lblLapTrinh.Font.Style ^ FontStyle.Underline);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name,
                                      txtNhapTen.Font.Size,
                                      txtNhapTen.Font.Style ^ FontStyle.Underline);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

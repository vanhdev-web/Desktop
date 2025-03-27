using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class PhuongTrinh : Form
    {
        public PhuongTrinh()
        {
            InitializeComponent();

            btnTinh.Enabled = false;
            btnXoa.Enabled = false;

            this.AcceptButton = btnTinh;
            this.CancelButton = btnThoat;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void CheckInput()
        {
            
            double a, b;
            bool isAValid = !string.IsNullOrEmpty(txtA.Text) && double.TryParse(txtA.Text, out a);
            bool isBValid = !string.IsNullOrEmpty(txtB.Text) && double.TryParse(txtB.Text, out b);

           
            if (isAValid)
                errorProvider1.SetError(txtA, "");
            if (isBValid)
                errorProvider1.SetError(txtB, "");

            
            if (!string.IsNullOrEmpty(txtA.Text) && !isAValid)
                errorProvider1.SetError(txtA, "Hệ số A phải là số");
            if (!string.IsNullOrEmpty(txtB.Text) && !isBValid)
                errorProvider1.SetError(txtB, "Hệ số B phải là số");

            
            btnTinh.Enabled = isAValid && isBValid;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            
            double a, b;
            if (!double.TryParse(txtA.Text, out a) || !double.TryParse(txtB.Text, out b))
            {
                return;
            }

            if (a == 0)
            {
                if (b == 0)
                    txtNghiemPT.Text = "Phương trình có vô số nghiệm";
                else
                    txtNghiemPT.Text = "Phương trình vô nghiệm";
            }
            else
            {
                double x = -b / a;
                txtNghiemPT.Text = "x = " + x.ToString();
            }

            btnXoa.Enabled = true;
            btnTinh.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            txtA.Clear();
            txtB.Clear();
            txtNghiemPT.Clear();

            
            errorProvider1.Clear();

            
            txtA.Focus();

            
            btnXoa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi ứng dụng không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class ChangeMoney : Form
    {
        // khai bao hang so ty gia 
        private const double USD_RATE = 17861;
        private const double EUR_RATE = 27043;
        public ChangeMoney()
        {
            InitializeComponent();
        }
        private bool IsValidInput()
        {
            bool isValid = true;

            
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                errorProvider1.SetError(txtAmount, "Vui lòng nhập số tiền");
                isValid = false;
            }
            else
            {
                double amount;
                if (!double.TryParse(txtAmount.Text, out amount))
                {
                    errorProvider1.SetError(txtAmount, "Số tiền phải là số hợp lệ");
                    isValid = false;
                }
                else
                {
                    errorProvider1.SetError(txtAmount, "");
                }

                if (amount < 0)
                {
                    errorProvider1.SetError(txtAmount, "Số tiền không được là số âm");
                    return false;
                }
            }



            
            double usdRate;
            if (string.IsNullOrEmpty(txtUSDRate.Text) ||
                !double.TryParse(txtUSDRate.Text, out usdRate) ||
                usdRate <= 0)
            {
                errorProvider1.SetError(txtUSDRate, "Tỷ giá USD phải là số dương");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtUSDRate, "");
            }

            
            double eurRate;
            if (string.IsNullOrEmpty(txtEURRate.Text) ||
                !double.TryParse(txtEURRate.Text, out eurRate) ||
                eurRate <= 0)
            {
                errorProvider1.SetError(txtEURRate, "Tỷ giá EUR phải là số dương");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtEURRate, "");
            }

            return isValid;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                errorProvider1.SetError(txtAmount, "Vui lòng nhập số tiền");
                return;
            }

            double amount;
            if (!double.TryParse(txtAmount.Text, out amount))
            {
                errorProvider1.SetError(txtAmount, "Số tiền phải là số hợp lệ");
                return;
            }

            if (amount < 0)
            {
                errorProvider1.SetError(txtAmount, "Số tiền không được là số âm");
                return;
            }


            errorProvider1.Clear();
        }

        private void btnVNDtoUSD_Click(object sender, EventArgs e)
        {
            if (!IsValidInput()) return;
            double vnd = double.Parse(txtAmount.Text);
            double usd = vnd / GetUSDRate();
            lblKetQua.Text = Math.Round(usd, 2).ToString();
        }

        private void btnUSDtoVND_Click(object sender, EventArgs e)
        {
            if (!IsValidInput()) return;

            double usd = double.Parse(txtAmount.Text);
            double vnd = usd * GetUSDRate();
            lblKetQua.Text = Math.Round(vnd, 2).ToString();
        }

        private void btnVNDtoEUR_Click(object sender, EventArgs e)
        {
            if (!IsValidInput()) return;

            double vnd = double.Parse(txtAmount.Text);
            double eur = vnd / GetEURRate();
            lblKetQua.Text = Math.Round(eur, 2).ToString();
        }

        private void btnEURtoVND_Click(object sender, EventArgs e)
        {
            if (!IsValidInput()) return;

            double eur = double.Parse(txtAmount.Text);
            double vnd = eur * GetEURRate();
            lblKetQua.Text = Math.Round(vnd, 2).ToString();
        }

        private void ChangeMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?",
                                   "Xác nhận",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private double GetUSDRate()
        {
            double rate;
            if (double.TryParse(txtUSDRate.Text, out rate) && rate > 0)
                return rate;

            
            errorProvider1.SetError(txtUSDRate, "Tỷ giá USD phải là số dương");
            return USD_RATE; 
        }

        private double GetEURRate()
        {
            double rate;
            if (double.TryParse(txtEURRate.Text, out rate) && rate > 0)
                return rate;

            
            errorProvider1.SetError(txtEURRate, "Tỷ giá EUR phải là số dương");
            return EUR_RATE; 
        }

        private void txtUSDRate_TextChanged(object sender, EventArgs e)
        {
            double rate;
            if (string.IsNullOrEmpty(txtUSDRate.Text) ||
                !double.TryParse(txtUSDRate.Text, out rate) ||
                rate <= 0)
            {
                errorProvider1.SetError(txtUSDRate, "Tỷ giá USD phải là số dương");
            }
            else
            {
                errorProvider1.SetError(txtUSDRate, "");
            }
        }

        private void txtEURRate_TextChanged(object sender, EventArgs e)
        {
            double rate;
            if (string.IsNullOrEmpty(txtEURRate.Text) ||
                !double.TryParse(txtEURRate.Text, out rate) ||
                rate <= 0)
            {
                errorProvider1.SetError(txtEURRate, "Tỷ giá EUR phải là số dương");
            }
            else
            {
                errorProvider1.SetError(txtEURRate, "");
            }
        }

        private void ChangeMoney_Load(object sender, EventArgs e)
        {
            // ty gia mac dinh
            txtUSDRate.Text = USD_RATE.ToString();
            txtEURRate.Text = EUR_RATE.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtAmount.Clear();

           
            lblKetQua.Text = "";

          
            errorProvider1.Clear();

            
            txtAmount.Focus();
        }
    }
}

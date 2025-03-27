using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class frmGroupBoxPanel : Form
    {
        public frmGroupBoxPanel()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            ofdPicture.Filter = "Image Files (BMP, GIF, JPEG, etc.)|" +
                               "*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tif;*.tiff|" +
                               "BMP Files (*.bmp)|*.bmp|" +
                               "GIF Files (*.gif)|*.gif|" +
                               "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                               "PNG Files (*.png)|*.png|" +
                               "TIF Files (*.tif;*.tiff)|*.tif;*.tiff|" +
                               "All Files (*.*)|*.*";

            
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    FileInfo file = new FileInfo(ofdPicture.FileName);

                    
                    lblSize.Text = String.Format("File Size: {0} Bytes", file.Length.ToString());
                    lblDateModified.Text = String.Format("Date last modified: {0}",
                                                   file.LastWriteTime.ToLongDateString());
                    lblDateAccessed.Text = String.Format("Date last accessed: {0}",
                                                   file.LastAccessTime.ToLongDateString());

                    
                    pbImage.Image = new Bitmap(ofdPicture.FileName);

                    
                    pbImage.Size = pbImage.Image.Size;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi mở file: " + ex.Message,
                                  "Lỗi",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }
    }
}

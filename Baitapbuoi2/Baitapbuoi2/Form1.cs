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

namespace Baitapbuoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                var path = dialog.SelectedPath;
                string[] file = Directory.GetFiles(path);
                foreach ( string file2 in file )
                {
                    if (file2.EndsWith(".pnj")|| file2.EndsWith(".jpg")){
                        PictureBox newPictureBox = new PictureBox();
                        newPictureBox.Load(file2 );
                        newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        newPictureBox.Cursor = Cursors.Hand;
                        ListPictureFlowPanel.Controls.Add(newPictureBox);
                        newPictureBox.Tag = file2;
                        newPictureBox.Click += PictureBox_Click;
                    } 
                }
            }
            
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                var path = pictureBox.Tag.ToString();
                pictureShowPictureBox.Load(path);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                fileLocationLabel.Text = path;
            }
        }


        private void pictureShowPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void ListPictureFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

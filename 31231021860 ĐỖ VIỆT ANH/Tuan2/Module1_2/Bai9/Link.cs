using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Link : Form
    {
        public Link()
        {
            InitializeComponent();

            lnkPrograms.Links.Add(0, "Launch Calculator".Length, "calc.exe");

            
            lnkPrograms.Links.Add(lnkPrograms.Text.IndexOf("Open C: Drive"),
                                 "Open C: Drive".Length,
                                 "c:\\");

           
            lnkPrograms.AutoSize = true;
        }

        private void lnkWinForms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            lnkWinForms.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.windowsforms.net");
        }

        private void lnkPrograms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}

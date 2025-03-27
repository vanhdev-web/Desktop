namespace Bai9
{
    partial class Link
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnkWinForms = new System.Windows.Forms.LinkLabel();
            this.lnkPrograms = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkWinForms
            // 
            this.lnkWinForms.AutoSize = true;
            this.lnkWinForms.Location = new System.Drawing.Point(56, 64);
            this.lnkWinForms.Name = "lnkWinForms";
            this.lnkWinForms.Size = new System.Drawing.Size(281, 21);
            this.lnkWinForms.TabIndex = 0;
            this.lnkWinForms.TabStop = true;
            this.lnkWinForms.Text = "Windows Forms Community Website";
            this.lnkWinForms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWinForms_LinkClicked);
            // 
            // lnkPrograms
            // 
            this.lnkPrograms.AutoSize = true;
            this.lnkPrograms.Location = new System.Drawing.Point(75, 122);
            this.lnkPrograms.Name = "lnkPrograms";
            this.lnkPrograms.Size = new System.Drawing.Size(262, 21);
            this.lnkPrograms.TabIndex = 1;
            this.lnkPrograms.TabStop = true;
            this.lnkPrograms.Text = "Launch Calculator | Open C: Drive";
            this.lnkPrograms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPrograms_LinkClicked);
            // 
            // Link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 301);
            this.Controls.Add(this.lnkPrograms);
            this.Controls.Add(this.lnkWinForms);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Link";
            this.Text = "StepByStep2_7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkWinForms;
        private System.Windows.Forms.LinkLabel lnkPrograms;
    }
}


namespace Bai10
{
    partial class frmGroupBoxPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grpFileStats = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDateModified = new System.Windows.Forms.Label();
            this.lblDateAccessed = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.grpFileStats.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click button to open a picture file: ";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(401, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(121, 38);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grpFileStats
            // 
            this.grpFileStats.Controls.Add(this.lblDateAccessed);
            this.grpFileStats.Controls.Add(this.lblDateModified);
            this.grpFileStats.Controls.Add(this.lblSize);
            this.grpFileStats.ForeColor = System.Drawing.Color.Blue;
            this.grpFileStats.Location = new System.Drawing.Point(80, 104);
            this.grpFileStats.Name = "grpFileStats";
            this.grpFileStats.Size = new System.Drawing.Size(468, 150);
            this.grpFileStats.TabIndex = 2;
            this.grpFileStats.TabStop = false;
            this.grpFileStats.Text = "File Statistics";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSize.Location = new System.Drawing.Point(24, 28);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(82, 21);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "File Size: ";
            // 
            // lblDateModified
            // 
            this.lblDateModified.AutoSize = true;
            this.lblDateModified.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDateModified.Location = new System.Drawing.Point(24, 66);
            this.lblDateModified.Name = "lblDateModified";
            this.lblDateModified.Size = new System.Drawing.Size(160, 21);
            this.lblDateModified.TabIndex = 1;
            this.lblDateModified.Text = "Date Last Modified: ";
            // 
            // lblDateAccessed
            // 
            this.lblDateAccessed.AutoSize = true;
            this.lblDateAccessed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDateAccessed.Location = new System.Drawing.Point(24, 104);
            this.lblDateAccessed.Name = "lblDateAccessed";
            this.lblDateAccessed.Size = new System.Drawing.Size(168, 21);
            this.lblDateAccessed.TabIndex = 2;
            this.lblDateAccessed.Text = "Date Last Accessed: ";
            // 
            // pnlImage
            // 
            this.pnlImage.AutoScroll = true;
            this.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImage.Controls.Add(this.pbImage);
            this.pnlImage.Location = new System.Drawing.Point(80, 282);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(468, 241);
            this.pnlImage.TabIndex = 3;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(2, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(462, 233);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "openFileDialog1";
            // 
            // frmGroupBoxPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(654, 547);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.grpFileStats);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGroupBoxPanel";
            this.Text = "StepByStep2_8";
            this.grpFileStats.ResumeLayout(false);
            this.grpFileStats.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox grpFileStats;
        private System.Windows.Forms.Label lblDateAccessed;
        private System.Windows.Forms.Label lblDateModified;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
    }
}


namespace Baitapbuoi2
{
    partial class Form1
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
            this.ShowPicturePanel = new System.Windows.Forms.Panel();
            this.ListPictureFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.fileLocationLabel = new System.Windows.Forms.Label();
            this.pictureShowPictureBox = new System.Windows.Forms.PictureBox();
            this.ShowPicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPicturePanel
            // 
            this.ShowPicturePanel.Controls.Add(this.pictureShowPictureBox);
            this.ShowPicturePanel.Location = new System.Drawing.Point(12, 78);
            this.ShowPicturePanel.Name = "ShowPicturePanel";
            this.ShowPicturePanel.Size = new System.Drawing.Size(968, 147);
            this.ShowPicturePanel.TabIndex = 0;
            // 
            // ListPictureFlowPanel
            // 
            this.ListPictureFlowPanel.Location = new System.Drawing.Point(12, 231);
            this.ListPictureFlowPanel.Name = "ListPictureFlowPanel";
            this.ListPictureFlowPanel.Size = new System.Drawing.Size(968, 85);
            this.ListPictureFlowPanel.TabIndex = 1;
            this.ListPictureFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ListPictureFlowPanel_Paint);
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(12, 12);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(106, 34);
            this.loadFileButton.TabIndex = 0;
            this.loadFileButton.Text = "&Load File";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // fileLocationLabel
            // 
            this.fileLocationLabel.Location = new System.Drawing.Point(22, 390);
            this.fileLocationLabel.Name = "fileLocationLabel";
            this.fileLocationLabel.Size = new System.Drawing.Size(100, 23);
            this.fileLocationLabel.TabIndex = 2;
            this.fileLocationLabel.Text = "label1";
            // 
            // pictureShowPictureBox
            // 
            this.pictureShowPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureShowPictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureShowPictureBox.Name = "pictureShowPictureBox";
            this.pictureShowPictureBox.Size = new System.Drawing.Size(968, 147);
            this.pictureShowPictureBox.TabIndex = 0;
            this.pictureShowPictureBox.TabStop = false;
            this.pictureShowPictureBox.Click += new System.EventHandler(this.pictureShowPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 468);
            this.Controls.Add(this.fileLocationLabel);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.ListPictureFlowPanel);
            this.Controls.Add(this.ShowPicturePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ShowPicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ShowPicturePanel;
        private System.Windows.Forms.FlowLayoutPanel ListPictureFlowPanel;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Label fileLocationLabel;
        private System.Windows.Forms.PictureBox pictureShowPictureBox;
    }
}


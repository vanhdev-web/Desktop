namespace Bai7
{
    partial class frmLight
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picTurnOff = new System.Windows.Forms.PictureBox();
            this.picTurnOn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 28);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblHienThi
            // 
            this.lblHienThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHienThi.Location = new System.Drawing.Point(70, 243);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(358, 42);
            this.lblHienThi.TabIndex = 4;
            this.lblHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Designed by: _________________";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(369, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 48);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picTurnOff
            // 
            this.picTurnOff.Image = global::Bai7.Properties.Resources.lightbulb_off__1___1_;
            this.picTurnOff.Location = new System.Drawing.Point(194, 115);
            this.picTurnOff.Name = "picTurnOff";
            this.picTurnOff.Size = new System.Drawing.Size(98, 104);
            this.picTurnOff.TabIndex = 3;
            this.picTurnOff.TabStop = false;
            this.picTurnOff.Visible = false;
            this.picTurnOff.Click += new System.EventHandler(this.picTurnOff_Click);
            // 
            // picTurnOn
            // 
            this.picTurnOn.Image = global::Bai7.Properties.Resources.lightbulb_on;
            this.picTurnOn.Location = new System.Drawing.Point(194, 115);
            this.picTurnOn.Name = "picTurnOn";
            this.picTurnOn.Size = new System.Drawing.Size(98, 103);
            this.picTurnOn.TabIndex = 2;
            this.picTurnOn.TabStop = false;
            this.picTurnOn.Click += new System.EventHandler(this.picTurnOn_Click);
            // 
            // frmLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(480, 417);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.picTurnOff);
            this.Controls.Add(this.picTurnOn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLight";
            this.Load += new System.EventHandler(this.frmLight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picTurnOn;
        private System.Windows.Forms.PictureBox picTurnOff;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


namespace Bai11
{
    partial class frmFont
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
            this.txtVanBan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radCourierNew = new System.Windows.Forms.RadioButton();
            this.radTahoma = new System.Windows.Forms.RadioButton();
            this.radArial = new System.Windows.Forms.RadioButton();
            this.radTimesNewRoman = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập văn bản: ";
            // 
            // txtVanBan
            // 
            this.txtVanBan.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVanBan.ForeColor = System.Drawing.Color.Blue;
            this.txtVanBan.Location = new System.Drawing.Point(76, 91);
            this.txtVanBan.Multiline = true;
            this.txtVanBan.Name = "txtVanBan";
            this.txtVanBan.Size = new System.Drawing.Size(243, 267);
            this.txtVanBan.TabIndex = 1;
            this.txtVanBan.Text = "WHAT FONT IS THIS?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radCourierNew);
            this.panel1.Controls.Add(this.radTahoma);
            this.panel1.Controls.Add(this.radArial);
            this.panel1.Controls.Add(this.radTimesNewRoman);
            this.panel1.Location = new System.Drawing.Point(359, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 267);
            this.panel1.TabIndex = 2;
            // 
            // radCourierNew
            // 
            this.radCourierNew.AutoSize = true;
            this.radCourierNew.Location = new System.Drawing.Point(23, 199);
            this.radCourierNew.Name = "radCourierNew";
            this.radCourierNew.Size = new System.Drawing.Size(122, 25);
            this.radCourierNew.TabIndex = 3;
            this.radCourierNew.TabStop = true;
            this.radCourierNew.Text = "Courier New";
            this.radCourierNew.UseVisualStyleBackColor = true;
            this.radCourierNew.CheckedChanged += new System.EventHandler(this.radCourierNew_CheckedChanged);
            // 
            // radTahoma
            // 
            this.radTahoma.AutoSize = true;
            this.radTahoma.Location = new System.Drawing.Point(23, 145);
            this.radTahoma.Name = "radTahoma";
            this.radTahoma.Size = new System.Drawing.Size(91, 25);
            this.radTahoma.TabIndex = 2;
            this.radTahoma.TabStop = true;
            this.radTahoma.Text = "Tahoma";
            this.radTahoma.UseVisualStyleBackColor = true;
            this.radTahoma.CheckedChanged += new System.EventHandler(this.radTahoma_CheckedChanged);
            // 
            // radArial
            // 
            this.radArial.AutoSize = true;
            this.radArial.Location = new System.Drawing.Point(23, 84);
            this.radArial.Name = "radArial";
            this.radArial.Size = new System.Drawing.Size(65, 25);
            this.radArial.TabIndex = 1;
            this.radArial.TabStop = true;
            this.radArial.Text = "Arial";
            this.radArial.UseVisualStyleBackColor = true;
            this.radArial.CheckedChanged += new System.EventHandler(this.radArial_CheckedChanged);
            // 
            // radTimesNewRoman
            // 
            this.radTimesNewRoman.AutoSize = true;
            this.radTimesNewRoman.Location = new System.Drawing.Point(23, 29);
            this.radTimesNewRoman.Name = "radTimesNewRoman";
            this.radTimesNewRoman.Size = new System.Drawing.Size(171, 25);
            this.radTimesNewRoman.TabIndex = 0;
            this.radTimesNewRoman.TabStop = true;
            this.radTimesNewRoman.Text = "Times New Roman";
            this.radTimesNewRoman.UseVisualStyleBackColor = true;
            this.radTimesNewRoman.CheckedChanged += new System.EventHandler(this.radTimesNewRoman_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(220, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 45);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 470);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtVanBan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFont";
            this.Text = "frmFont";
            this.Load += new System.EventHandler(this.frmFont_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVanBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radCourierNew;
        private System.Windows.Forms.RadioButton radTahoma;
        private System.Windows.Forms.RadioButton radArial;
        private System.Windows.Forms.RadioButton radTimesNewRoman;
        private System.Windows.Forms.Button btnThoat;
    }
}


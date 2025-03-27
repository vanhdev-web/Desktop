namespace Bai3
{
    partial class BtHoTen
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHo = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.LightCyan;
            this.lblHoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(0, 0);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(729, 64);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "\r\n                                                                               " +
    "      ";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHoTen.DoubleClick += new System.EventHandler(this.lblHoTen_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ lót";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(180, 103);
            this.txtHo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(321, 20);
            this.txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtTen.ForeColor = System.Drawing.Color.Black;
            this.txtTen.Location = new System.Drawing.Point(180, 132);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(321, 20);
            this.txtTen.TabIndex = 4;
            // 
            // btnHo
            // 
            this.btnHo.Location = new System.Drawing.Point(146, 163);
            this.btnHo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(113, 39);
            this.btnHo.TabIndex = 5;
            this.btnHo.Text = "Tên lót";
            this.btnHo.UseVisualStyleBackColor = true;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(272, 163);
            this.btnTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(113, 39);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Location = new System.Drawing.Point(410, 163);
            this.btnHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(113, 39);
            this.btnHoTen.TabIndex = 7;
            this.btnHoTen.Text = "Họ và Tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKetThuc.Location = new System.Drawing.Point(235, 214);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(187, 36);
            this.btnKetThuc.TabIndex = 8;
            this.btnKetThuc.Text = "Exit";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // BtHoTen
            // 
            this.AcceptButton = this.btnHoTen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKetThuc;
            this.ClientSize = new System.Drawing.Size(729, 291);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHo);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHoTen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BtHoTen";
            this.Text = "Bài Tập Họ Tên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnKetThuc;
    }
}


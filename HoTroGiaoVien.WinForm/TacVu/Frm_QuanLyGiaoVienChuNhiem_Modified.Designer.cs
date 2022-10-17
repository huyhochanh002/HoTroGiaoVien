namespace HoTroGiaoVien.WinForm.TacVu
{
    partial class Frm_QuanLyGiaoVienChuNhiem_Modified
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaGiaoVien = new HoTroGiaoVien.Commons.TextColor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoGiaoVien = new HoTroGiaoVien.Commons.TextColor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenGiaoVien = new HoTroGiaoVien.Commons.TextColor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienThoai = new HoTroGiaoVien.Commons.TextColor();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new HoTroGiaoVien.Commons.TextColor();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFacebook = new HoTroGiaoVien.Commons.TextColor();
            this.label8 = new System.Windows.Forms.Label();
            this.txtZalo = new HoTroGiaoVien.Commons.TextColor();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi = new HoTroGiaoVien.Commons.TextColor();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCapNhat = new HoTroGiaoVien.Commons.CircleButton();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(832, 50);
            this.pnlTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập nhật thông tin giáo viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::HoTroGiaoVien.WinForm.Properties.Resources.group_32px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::HoTroGiaoVien.WinForm.Properties.Resources.close_window_32px;
            this.btnClose.Location = new System.Drawing.Point(782, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(832, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.ForeColor = System.Drawing.Color.White;
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 17);
            this.lblErr.Text = "...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 329);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(828, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 329);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã giáo viên:";
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.BackColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtMaGiaoVien.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtMaGiaoVien.Location = new System.Drawing.Point(12, 84);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.Size = new System.Drawing.Size(167, 36);
            this.txtMaGiaoVien.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ giáo viên:";
            // 
            // txtHoGiaoVien
            // 
            this.txtHoGiaoVien.BackColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtHoGiaoVien.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtHoGiaoVien.Location = new System.Drawing.Point(185, 84);
            this.txtHoGiaoVien.Name = "txtHoGiaoVien";
            this.txtHoGiaoVien.Size = new System.Drawing.Size(322, 36);
            this.txtHoGiaoVien.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên giáo viên:";
            // 
            // txtTenGiaoVien
            // 
            this.txtTenGiaoVien.BackColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtTenGiaoVien.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtTenGiaoVien.Location = new System.Drawing.Point(513, 84);
            this.txtTenGiaoVien.Name = "txtTenGiaoVien";
            this.txtTenGiaoVien.Size = new System.Drawing.Size(304, 36);
            this.txtTenGiaoVien.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtDienThoai.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtDienThoai.Location = new System.Drawing.Point(12, 150);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(167, 36);
            this.txtDienThoai.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtEmail.Location = new System.Drawing.Point(185, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(322, 36);
            this.txtEmail.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(513, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Facebook:";
            // 
            // txtFacebook
            // 
            this.txtFacebook.BackColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtFacebook.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtFacebook.Location = new System.Drawing.Point(513, 150);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(304, 36);
            this.txtFacebook.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Zalo:";
            // 
            // txtZalo
            // 
            this.txtZalo.BackColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtZalo.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtZalo.Location = new System.Drawing.Point(12, 218);
            this.txtZalo.Name = "txtZalo";
            this.txtZalo.Size = new System.Drawing.Size(167, 36);
            this.txtZalo.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtDiaChi.Location = new System.Drawing.Point(185, 218);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(632, 36);
            this.txtDiaChi.TabIndex = 23;
            // 
            // cboKhoa
            // 
            this.cboKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(16, 284);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(801, 37);
            this.cboKhoa.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Khoa:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 10;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(607, 327);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(210, 40);
            this.btnCapNhat.TabIndex = 27;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // Frm_QuanLyGiaoVienChuNhiem_Modified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 401);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtZalo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFacebook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenGiaoVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoGiaoVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaGiaoVien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QuanLyGiaoVienChuNhiem_Modified";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_QuanLyGiaoVienChuNhiem_Modified";
            this.Load += new System.EventHandler(this.Frm_QuanLyGiaoVienChuNhiem_Modified_Load);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Commons.TextColor txtMaGiaoVien;
        private System.Windows.Forms.Label label3;
        private Commons.TextColor txtHoGiaoVien;
        private System.Windows.Forms.Label label4;
        private Commons.TextColor txtTenGiaoVien;
        private System.Windows.Forms.Label label5;
        private Commons.TextColor txtDienThoai;
        private System.Windows.Forms.Label label6;
        private Commons.TextColor txtEmail;
        private System.Windows.Forms.Label label7;
        private Commons.TextColor txtFacebook;
        private System.Windows.Forms.Label label8;
        private Commons.TextColor txtZalo;
        private System.Windows.Forms.Label label9;
        private Commons.TextColor txtDiaChi;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label10;
        private Commons.CircleButton btnCapNhat;
    }
}
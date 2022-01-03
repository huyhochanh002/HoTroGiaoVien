
namespace HoTroGiaoVien.WinForm
{
    partial class FrmThayDoiMatKhau_Main
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtPassWordNew = new HoTroGiaoVien.Commons.WaterMarkTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrePasswordNew = new HoTroGiaoVien.Commons.WaterMarkTextBox();
            this.btnDoiMatKhau = new HoTroGiaoVien.Commons.CircleButton();
            this.gbResetPassword = new System.Windows.Forms.GroupBox();
            this.cboTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetPassword = new HoTroGiaoVien.Commons.CircleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbResetPassword.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.btnThoat);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(800, 50);
            this.pnlTitle.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(700, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đổi mật khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::HoTroGiaoVien.WinForm.Properties.Resources.key_2_32px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Image = global::HoTroGiaoVien.WinForm.Properties.Resources.close_window_32px;
            this.btnThoat.Location = new System.Drawing.Point(750, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(50, 50);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtPassWordNew
            // 
            this.txtPassWordNew.BackColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtPassWordNew.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtPassWordNew.Location = new System.Drawing.Point(6, 19);
            this.txtPassWordNew.Name = "txtPassWordNew";
            this.txtPassWordNew.PasswordChar = '@';
            this.txtPassWordNew.Size = new System.Drawing.Size(764, 36);
            this.txtPassWordNew.TabIndex = 4;
            this.txtPassWordNew.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPassWordNew.WaterMarkText = "Nhập mật khẩu mới";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoiMatKhau);
            this.groupBox1.Controls.Add(this.txtPrePasswordNew);
            this.groupBox1.Controls.Add(this.txtPassWordNew);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            // 
            // txtPrePasswordNew
            // 
            this.txtPrePasswordNew.BackColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtPrePasswordNew.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtPrePasswordNew.Location = new System.Drawing.Point(6, 61);
            this.txtPrePasswordNew.Name = "txtPrePasswordNew";
            this.txtPrePasswordNew.PasswordChar = '#';
            this.txtPrePasswordNew.Size = new System.Drawing.Size(764, 36);
            this.txtPrePasswordNew.TabIndex = 5;
            this.txtPrePasswordNew.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPrePasswordNew.WaterMarkText = "Nhập lại mật khẩu mới";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDoiMatKhau.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDoiMatKhau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDoiMatKhau.BorderRadius = 10;
            this.btnDoiMatKhau.BorderSize = 0;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(605, 103);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(165, 40);
            this.btnDoiMatKhau.TabIndex = 6;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.TextColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            // 
            // gbResetPassword
            // 
            this.gbResetPassword.Controls.Add(this.btnResetPassword);
            this.gbResetPassword.Controls.Add(this.label2);
            this.gbResetPassword.Controls.Add(this.cboTaiKhoan);
            this.gbResetPassword.Location = new System.Drawing.Point(12, 216);
            this.gbResetPassword.Name = "gbResetPassword";
            this.gbResetPassword.Size = new System.Drawing.Size(776, 146);
            this.gbResetPassword.TabIndex = 6;
            this.gbResetPassword.TabStop = false;
            this.gbResetPassword.Text = "Cấp lại mật khẩu:";
            // 
            // cboTaiKhoan
            // 
            this.cboTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTaiKhoan.FormattingEnabled = true;
            this.cboTaiKhoan.Location = new System.Drawing.Point(6, 50);
            this.cboTaiKhoan.Name = "cboTaiKhoan";
            this.cboTaiKhoan.Size = new System.Drawing.Size(764, 37);
            this.cboTaiKhoan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn tài khoản muốn cập lại:";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnResetPassword.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnResetPassword.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnResetPassword.BorderRadius = 10;
            this.btnResetPassword.BorderSize = 0;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(605, 93);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(165, 40);
            this.btnResetPassword.TabIndex = 7;
            this.btnResetPassword.Text = "Cấp lại mật khẩu";
            this.btnResetPassword.TextColor = System.Drawing.Color.White;
            this.btnResetPassword.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.ForeColor = System.Drawing.Color.White;
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 17);
            this.lblErr.Text = "...";
            // 
            // FrmThayDoiMatKhau_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbResetPassword);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThayDoiMatKhau_Main";
            this.Text = "FrmThayDoiMatKhau_Main";
            this.Load += new System.EventHandler(this.FrmThayDoiMatKhau_Main_Load);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbResetPassword.ResumeLayout(false);
            this.gbResetPassword.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
        private Commons.WaterMarkTextBox txtPassWordNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private Commons.CircleButton btnDoiMatKhau;
        private Commons.WaterMarkTextBox txtPrePasswordNew;
        private System.Windows.Forms.GroupBox gbResetPassword;
        private Commons.CircleButton btnResetPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTaiKhoan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
    }
}
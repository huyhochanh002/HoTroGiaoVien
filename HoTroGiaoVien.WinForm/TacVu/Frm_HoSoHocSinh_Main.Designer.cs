
namespace HoTroGiaoVien.WinForm.TacVu
{
    partial class Frm_HoSoHocSinh_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HoSoHocSinh_Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn__NapLai = new System.Windows.Forms.ToolStripButton();
            this.btn__Them = new System.Windows.Forms.ToolStripButton();
            this.btn__Sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBaoLuu = new System.Windows.Forms.ToolStripButton();
            this.btnChoNghiLuon = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnGhiChuThongTin = new System.Windows.Forms.ToolStripButton();
            this.btnProfile = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.dgvDanhsachSinhVien = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.btnThoat);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1436, 50);
            this.pnlTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1336, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Hồ sơ chủ nhiệm lớp";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Image = global::HoTroGiaoVien.WinForm.Properties.Resources.close_window_32px;
            this.btnThoat.Location = new System.Drawing.Point(1386, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(50, 50);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(68)))));
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn__NapLai,
            this.btn__Them,
            this.btn__Sua,
            this.toolStripSeparator1,
            this.btnBaoLuu,
            this.btnChoNghiLuon,
            this.toolStripButton1,
            this.toolStripButton2,
            this.btnGhiChuThongTin,
            this.btnProfile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1436, 32);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn__NapLai
            // 
            this.btn__NapLai.Image = ((System.Drawing.Image)(resources.GetObject("btn__NapLai.Image")));
            this.btn__NapLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__NapLai.Name = "btn__NapLai";
            this.btn__NapLai.Size = new System.Drawing.Size(77, 24);
            this.btn__NapLai.Text = "Nạp lại";
            // 
            // btn__Them
            // 
            this.btn__Them.Image = ((System.Drawing.Image)(resources.GetObject("btn__Them.Image")));
            this.btn__Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__Them.Name = "btn__Them";
            this.btn__Them.Size = new System.Drawing.Size(127, 24);
            this.btn__Them.Text = "Thêm sinh viên";
            this.btn__Them.Click += new System.EventHandler(this.btn__Them_Click);
            // 
            // btn__Sua
            // 
            this.btn__Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn__Sua.Image")));
            this.btn__Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__Sua.Name = "btn__Sua";
            this.btn__Sua.Size = new System.Drawing.Size(54, 24);
            this.btn__Sua.Text = "Sửa";
            this.btn__Sua.Click += new System.EventHandler(this.btn__Sua_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnBaoLuu
            // 
            this.btnBaoLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoLuu.Image")));
            this.btnBaoLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBaoLuu.Name = "btnBaoLuu";
            this.btnBaoLuu.Size = new System.Drawing.Size(80, 24);
            this.btnBaoLuu.Text = "Bảo lưu";
            this.btnBaoLuu.Click += new System.EventHandler(this.btnBaoLuu_Click);
            // 
            // btnChoNghiLuon
            // 
            this.btnChoNghiLuon.Image = ((System.Drawing.Image)(resources.GetObject("btnChoNghiLuon.Image")));
            this.btnChoNghiLuon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChoNghiLuon.Name = "btnChoNghiLuon";
            this.btnChoNghiLuon.Size = new System.Drawing.Size(94, 24);
            this.btnChoNghiLuon.Text = "Nghỉ luôn";
            this.btnChoNghiLuon.Click += new System.EventHandler(this.btnChoNghiLuon_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(109, 24);
            this.toolStripButton1.Text = "Xứ lý học vụ";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(219, 24);
            this.toolStripButton2.Text = "Thêm thông tin nội ngoại trú";
            // 
            // btnGhiChuThongTin
            // 
            this.btnGhiChuThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiChuThongTin.Image")));
            this.btnGhiChuThongTin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGhiChuThongTin.Name = "btnGhiChuThongTin";
            this.btnGhiChuThongTin.Size = new System.Drawing.Size(203, 24);
            this.btnGhiChuThongTin.Text = "Ghi chú thông tin sinh viên";
            this.btnGhiChuThongTin.Click += new System.EventHandler(this.btnGhiChuThongTin_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(72, 24);
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 550);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1436, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 21);
            this.toolStripStatusLabel1.Text = "Số lượng sinh viên:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(19, 21);
            this.toolStripStatusLabel2.Text = "0";
            // 
            // lblErr
            // 
            this.lblErr.ForeColor = System.Drawing.Color.White;
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 21);
            this.lblErr.Text = "...";
            // 
            // cboLop
            // 
            this.cboLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(1165, 52);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(268, 28);
            this.cboLop.TabIndex = 9;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // dgvDanhsachSinhVien
            // 
            this.dgvDanhsachSinhVien.AllowUserToAddRows = false;
            this.dgvDanhsachSinhVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.dgvDanhsachSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhsachSinhVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhsachSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhsachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.Column1});
            this.dgvDanhsachSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhsachSinhVien.Location = new System.Drawing.Point(0, 82);
            this.dgvDanhsachSinhVien.Name = "dgvDanhsachSinhVien";
            this.dgvDanhsachSinhVien.ReadOnly = true;
            this.dgvDanhsachSinhVien.RowHeadersVisible = false;
            this.dgvDanhsachSinhVien.RowTemplate.Height = 28;
            this.dgvDanhsachSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhsachSinhVien.Size = new System.Drawing.Size(1436, 468);
            this.dgvDanhsachSinhVien.TabIndex = 10;
            this.dgvDanhsachSinhVien.Click += new System.EventHandler(this.dgvDanhsachSinhVien_Click);
            this.dgvDanhsachSinhVien.DoubleClick += new System.EventHandler(this.dgvDanhsachSinhVien_DoubleClick);
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Frm_HoSoHocSinh_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 576);
            this.Controls.Add(this.dgvDanhsachSinhVien);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_HoSoHocSinh_Main";
            this.Text = "Frm_HoSoHocSinh_Main";
            this.Load += new System.EventHandler(this.Frm_HoSoHocSinh_Main_Load);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn__NapLai;
        private System.Windows.Forms.ToolStripButton btn__Them;
        private System.Windows.Forms.ToolStripButton btn__Sua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnGhiChuThongTin;
        private System.Windows.Forms.DataGridView dgvDanhsachSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStripButton btnBaoLuu;
        private System.Windows.Forms.ToolStripButton btnChoNghiLuon;
        private System.Windows.Forms.ToolStripButton btnProfile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

namespace HoTroGiaoVien.WinForm.TacVu
{
    partial class Frm_XuLyHocVu_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_XuLyHocVu_Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn__NapLai = new System.Windows.Forms.ToolStripButton();
            this.btn__Sua = new System.Windows.Forms.ToolStripButton();
            this.btn__Thoat = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvChiTietXuLyHocVu = new System.Windows.Forms.DataGridView();
            this.btnCapNhatBaoLuu = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhatNghiHoc = new System.Windows.Forms.ToolStripButton();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiDungLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoaiXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietXuLyHocVu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.pnlTitle.Controls.Add(this.cboLop);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.btnThoat);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1327, 50);
            this.pnlTitle.TabIndex = 6;
            // 
            // cboLop
            // 
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(54, 10);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(253, 32);
            this.cboLop.TabIndex = 10;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1227, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Xử lý học vụ";
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
            this.btnThoat.Location = new System.Drawing.Point(1277, 0);
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
            this.btn__Sua,
            this.btnCapNhatBaoLuu,
            this.btnCapNhatNghiHoc,
            this.btn__Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1327, 32);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn__NapLai
            // 
            this.btn__NapLai.Image = ((System.Drawing.Image)(resources.GetObject("btn__NapLai.Image")));
            this.btn__NapLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__NapLai.Name = "btn__NapLai";
            this.btn__NapLai.Size = new System.Drawing.Size(77, 24);
            this.btn__NapLai.Text = "Nạp lại";
            this.btn__NapLai.Click += new System.EventHandler(this.btn__NapLai_Click);
            // 
            // btn__Sua
            // 
            this.btn__Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn__Sua.Image")));
            this.btn__Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__Sua.Name = "btn__Sua";
            this.btn__Sua.Size = new System.Drawing.Size(170, 24);
            this.btn__Sua.Text = "Cập nhật xử lý học vụ";
            this.btn__Sua.Click += new System.EventHandler(this.btn__Sua_Click);
            // 
            // btn__Thoat
            // 
            this.btn__Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn__Thoat.Image")));
            this.btn__Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__Thoat.Name = "btn__Thoat";
            this.btn__Thoat.Size = new System.Drawing.Size(67, 24);
            this.btn__Thoat.Text = "Thoát";
            this.btn__Thoat.Click += new System.EventHandler(this.btn__Thoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 720);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1327, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.ForeColor = System.Drawing.Color.White;
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 17);
            this.lblErr.Text = "...";
            // 
            // dgvChiTietXuLyHocVu
            // 
            this.dgvChiTietXuLyHocVu.AllowUserToAddRows = false;
            this.dgvChiTietXuLyHocVu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(168)))), ((int)(((byte)(222)))));
            this.dgvChiTietXuLyHocVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietXuLyHocVu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietXuLyHocVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietXuLyHocVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietXuLyHocVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaLop,
            this.colMaSinhVien,
            this.colTenSinhVien,
            this.colMaHocKy,
            this.colTenHocKy,
            this.colNgayLamViec,
            this.colNoiDungLamViec,
            this.colTenLoaiXuLy,
            this.colKetLuan,
            this.colMaLoaiXuLy});
            this.dgvChiTietXuLyHocVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietXuLyHocVu.Location = new System.Drawing.Point(0, 82);
            this.dgvChiTietXuLyHocVu.Name = "dgvChiTietXuLyHocVu";
            this.dgvChiTietXuLyHocVu.ReadOnly = true;
            this.dgvChiTietXuLyHocVu.RowHeadersVisible = false;
            this.dgvChiTietXuLyHocVu.RowTemplate.Height = 32;
            this.dgvChiTietXuLyHocVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietXuLyHocVu.Size = new System.Drawing.Size(1327, 638);
            this.dgvChiTietXuLyHocVu.TabIndex = 10;
            this.dgvChiTietXuLyHocVu.Click += new System.EventHandler(this.dgvChiTietXuLyHocVu_Click);
            this.dgvChiTietXuLyHocVu.DoubleClick += new System.EventHandler(this.dgvChiTietXuLyHocVu_DoubleClick);
            // 
            // btnCapNhatBaoLuu
            // 
            this.btnCapNhatBaoLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatBaoLuu.Image")));
            this.btnCapNhatBaoLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhatBaoLuu.Name = "btnCapNhatBaoLuu";
            this.btnCapNhatBaoLuu.Size = new System.Drawing.Size(143, 24);
            this.btnCapNhatBaoLuu.Text = "Cập nhật bảo lưu";
            this.btnCapNhatBaoLuu.Click += new System.EventHandler(this.btnCapNhatBaoLuu_Click);
            // 
            // btnCapNhatNghiHoc
            // 
            this.btnCapNhatNghiHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatNghiHoc.Image")));
            this.btnCapNhatNghiHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhatNghiHoc.Name = "btnCapNhatNghiHoc";
            this.btnCapNhatNghiHoc.Size = new System.Drawing.Size(149, 24);
            this.btnCapNhatNghiHoc.Text = "Cập nhật nghỉ học";
            this.btnCapNhatNghiHoc.Click += new System.EventHandler(this.btnCapNhatNghiHoc_Click);
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colMaLop
            // 
            this.colMaLop.DataPropertyName = "MaLop";
            this.colMaLop.HeaderText = "MaLop";
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.ReadOnly = true;
            this.colMaLop.Visible = false;
            // 
            // colMaSinhVien
            // 
            this.colMaSinhVien.DataPropertyName = "MaSinhVien";
            this.colMaSinhVien.HeaderText = "MSSV";
            this.colMaSinhVien.Name = "colMaSinhVien";
            this.colMaSinhVien.ReadOnly = true;
            // 
            // colTenSinhVien
            // 
            this.colTenSinhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSinhVien.DataPropertyName = "TenSinhVien";
            this.colTenSinhVien.HeaderText = "Họ tên sinh viên";
            this.colTenSinhVien.Name = "colTenSinhVien";
            this.colTenSinhVien.ReadOnly = true;
            // 
            // colMaHocKy
            // 
            this.colMaHocKy.DataPropertyName = "MaHocKy";
            this.colMaHocKy.HeaderText = "MaHocKy";
            this.colMaHocKy.Name = "colMaHocKy";
            this.colMaHocKy.ReadOnly = true;
            this.colMaHocKy.Visible = false;
            // 
            // colTenHocKy
            // 
            this.colTenHocKy.DataPropertyName = "TenHocKy";
            this.colTenHocKy.HeaderText = "Học kỳ";
            this.colTenHocKy.Name = "colTenHocKy";
            this.colTenHocKy.ReadOnly = true;
            this.colTenHocKy.Width = 200;
            // 
            // colNgayLamViec
            // 
            this.colNgayLamViec.DataPropertyName = "NgayLamViec";
            this.colNgayLamViec.HeaderText = "Ngày làm việc";
            this.colNgayLamViec.Name = "colNgayLamViec";
            this.colNgayLamViec.ReadOnly = true;
            // 
            // colNoiDungLamViec
            // 
            this.colNoiDungLamViec.DataPropertyName = "NoiDungLamViec";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colNoiDungLamViec.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNoiDungLamViec.HeaderText = "Nội dung làm việc";
            this.colNoiDungLamViec.Name = "colNoiDungLamViec";
            this.colNoiDungLamViec.ReadOnly = true;
            this.colNoiDungLamViec.Width = 300;
            // 
            // colTenLoaiXuLy
            // 
            this.colTenLoaiXuLy.DataPropertyName = "TenLoaiXuLy";
            this.colTenLoaiXuLy.HeaderText = "Loại xử lý";
            this.colTenLoaiXuLy.Name = "colTenLoaiXuLy";
            this.colTenLoaiXuLy.ReadOnly = true;
            this.colTenLoaiXuLy.Width = 150;
            // 
            // colKetLuan
            // 
            this.colKetLuan.DataPropertyName = "KetLuan";
            this.colKetLuan.HeaderText = "Kết luận";
            this.colKetLuan.Name = "colKetLuan";
            this.colKetLuan.ReadOnly = true;
            this.colKetLuan.Width = 150;
            // 
            // colMaLoaiXuLy
            // 
            this.colMaLoaiXuLy.DataPropertyName = "MaLoaiXuLy";
            this.colMaLoaiXuLy.HeaderText = "MaLoaiXuLy";
            this.colMaLoaiXuLy.Name = "colMaLoaiXuLy";
            this.colMaLoaiXuLy.ReadOnly = true;
            this.colMaLoaiXuLy.Visible = false;
            // 
            // Frm_XuLyHocVu_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 742);
            this.Controls.Add(this.dgvChiTietXuLyHocVu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_XuLyHocVu_Main";
            this.Text = "Frm_XuLyHocVu_Main";
            this.Load += new System.EventHandler(this.Frm_XuLyHocVu_Main_Load);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietXuLyHocVu)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btn__Sua;
        private System.Windows.Forms.ToolStripButton btn__Thoat;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.DataGridView dgvChiTietXuLyHocVu;
        private System.Windows.Forms.ToolStripButton btnCapNhatBaoLuu;
        private System.Windows.Forms.ToolStripButton btnCapNhatNghiHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLamViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiDungLamViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiXuLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetLuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiXuLy;
    }
}
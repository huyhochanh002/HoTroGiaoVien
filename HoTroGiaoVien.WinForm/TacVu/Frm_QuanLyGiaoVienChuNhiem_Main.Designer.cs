
namespace HoTroGiaoVien.WinForm.TacVu
{
    partial class Frm_QuanLyGiaoVienChuNhiem_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyGiaoVienChuNhiem_Main));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.btn__NapLai = new System.Windows.Forms.ToolStripButton();
            this.btn__Them = new System.Windows.Forms.ToolStripButton();
            this.btn__Sua = new System.Windows.Forms.ToolStripButton();
            this.btn__Xoa = new System.Windows.Forms.ToolStripButton();
            this.btnPhanGiaoVien = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitle.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlTitle.Size = new System.Drawing.Size(1290, 50);
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
            this.lblTitle.Size = new System.Drawing.Size(1190, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quản lý giáo viên chủ nhiệm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn__Xoa,
            this.btnPhanGiaoVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1290, 32);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1290, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.ForeColor = System.Drawing.Color.White;
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 17);
            this.lblErr.Text = "...";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.AllowUserToDeleteRows = false;
            this.dgvGiaoVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colHoGiaoVien,
            this.colTenGiaoVien,
            this.colMaGiaoVien,
            this.colHoTenGiaoVien,
            this.colDienThoai,
            this.colEmail,
            this.colFacebook,
            this.colZalo,
            this.colDiaChi,
            this.colMaKhoa,
            this.colTenKhoa,
            this.colMaNguoiDung});
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.Location = new System.Drawing.Point(0, 82);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersVisible = false;
            this.dgvGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoVien.Size = new System.Drawing.Size(1290, 421);
            this.dgvGiaoVien.TabIndex = 11;
            this.dgvGiaoVien.Click += new System.EventHandler(this.dgvGiaoVien_Click);
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
            // btn__Them
            // 
            this.btn__Them.Image = ((System.Drawing.Image)(resources.GetObject("btn__Them.Image")));
            this.btn__Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__Them.Name = "btn__Them";
            this.btn__Them.Size = new System.Drawing.Size(66, 24);
            this.btn__Them.Text = "Thêm";
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
            // btn__Xoa
            // 
            this.btn__Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn__Xoa.Image")));
            this.btn__Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__Xoa.Name = "btn__Xoa";
            this.btn__Xoa.Size = new System.Drawing.Size(55, 24);
            this.btn__Xoa.Text = "Xóa";
            this.btn__Xoa.Click += new System.EventHandler(this.btn__Xoa_Click);
            // 
            // btnPhanGiaoVien
            // 
            this.btnPhanGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanGiaoVien.Image")));
            this.btnPhanGiaoVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPhanGiaoVien.Name = "btnPhanGiaoVien";
            this.btnPhanGiaoVien.Size = new System.Drawing.Size(126, 24);
            this.btnPhanGiaoVien.Text = "Phân giáo viên";
            this.btnPhanGiaoVien.Click += new System.EventHandler(this.btnPhanGiaoVien_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(1240, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(50, 50);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 60;
            // 
            // colHoGiaoVien
            // 
            this.colHoGiaoVien.DataPropertyName = "HoGiaoVien";
            this.colHoGiaoVien.HeaderText = "Column1";
            this.colHoGiaoVien.Name = "colHoGiaoVien";
            this.colHoGiaoVien.ReadOnly = true;
            this.colHoGiaoVien.Visible = false;
            // 
            // colTenGiaoVien
            // 
            this.colTenGiaoVien.DataPropertyName = "TenGiaoVien";
            this.colTenGiaoVien.HeaderText = "Column1";
            this.colTenGiaoVien.Name = "colTenGiaoVien";
            this.colTenGiaoVien.ReadOnly = true;
            this.colTenGiaoVien.Visible = false;
            // 
            // colMaGiaoVien
            // 
            this.colMaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.colMaGiaoVien.HeaderText = "Mã giáo viên";
            this.colMaGiaoVien.Name = "colMaGiaoVien";
            this.colMaGiaoVien.ReadOnly = true;
            this.colMaGiaoVien.Visible = false;
            // 
            // colHoTenGiaoVien
            // 
            this.colHoTenGiaoVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTenGiaoVien.DataPropertyName = "HoTenGiaoVien";
            this.colHoTenGiaoVien.HeaderText = "Họ tên giáo viên";
            this.colHoTenGiaoVien.Name = "colHoTenGiaoVien";
            this.colHoTenGiaoVien.ReadOnly = true;
            // 
            // colDienThoai
            // 
            this.colDienThoai.DataPropertyName = "DienThoai";
            this.colDienThoai.HeaderText = "Điện thoại";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.ReadOnly = true;
            this.colDienThoai.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 150;
            // 
            // colFacebook
            // 
            this.colFacebook.DataPropertyName = "Facebook";
            this.colFacebook.HeaderText = "Facebook";
            this.colFacebook.Name = "colFacebook";
            this.colFacebook.ReadOnly = true;
            this.colFacebook.Width = 150;
            // 
            // colZalo
            // 
            this.colZalo.DataPropertyName = "Zalo";
            this.colZalo.HeaderText = "Zalo";
            this.colZalo.Name = "colZalo";
            this.colZalo.ReadOnly = true;
            this.colZalo.Width = 150;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.DataPropertyName = "MaKhoa";
            this.colMaKhoa.HeaderText = "Mã khoa";
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.ReadOnly = true;
            this.colMaKhoa.Visible = false;
            // 
            // colTenKhoa
            // 
            this.colTenKhoa.DataPropertyName = "TenKhoa";
            this.colTenKhoa.HeaderText = "Tên khoa";
            this.colTenKhoa.Name = "colTenKhoa";
            this.colTenKhoa.ReadOnly = true;
            this.colTenKhoa.Visible = false;
            // 
            // colMaNguoiDung
            // 
            this.colMaNguoiDung.DataPropertyName = "MaNguoiDung";
            this.colMaNguoiDung.HeaderText = "MaNguoiDung";
            this.colMaNguoiDung.Name = "colMaNguoiDung";
            this.colMaNguoiDung.ReadOnly = true;
            this.colMaNguoiDung.Visible = false;
            // 
            // Frm_QuanLyGiaoVienChuNhiem_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 525);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QuanLyGiaoVienChuNhiem_Main";
            this.Text = "Frm_QuanLyGiaoVienChuNhiem_Main";
            this.Load += new System.EventHandler(this.Frm_QuanLyGiaoVienChuNhiem_Main_Load);
            this.pnlTitle.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btn__Xoa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.ToolStripButton btnPhanGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTenGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNguoiDung;
    }
}
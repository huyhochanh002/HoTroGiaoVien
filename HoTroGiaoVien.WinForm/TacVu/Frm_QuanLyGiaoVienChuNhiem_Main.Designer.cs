﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyGiaoVienChuNhiem_Main));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn__NapLai = new System.Windows.Forms.ToolStripButton();
            this.btn__Them = new System.Windows.Forms.ToolStripButton();
            this.btn__Sua = new System.Windows.Forms.ToolStripButton();
            this.btn__Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn__Thoat = new System.Windows.Forms.ToolStripButton();
            this.btnPhanGiaoVien = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pnlTitle.Size = new System.Drawing.Size(1022, 50);
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
            this.lblTitle.Size = new System.Drawing.Size(922, 50);
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
            this.btn__Thoat,
            this.btnPhanGiaoVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1022, 32);
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
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 421);
            this.dataGridView1.TabIndex = 11;
           
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
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
            this.btn__Them.Size = new System.Drawing.Size(66, 24);
            this.btn__Them.Text = "Thêm";
            // 
            // btn__Sua
            // 
            this.btn__Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn__Sua.Image")));
            this.btn__Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__Sua.Name = "btn__Sua";
            this.btn__Sua.Size = new System.Drawing.Size(54, 24);
            this.btn__Sua.Text = "Sửa";
            // 
            // btn__Xoa
            // 
            this.btn__Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn__Xoa.Image")));
            this.btn__Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__Xoa.Name = "btn__Xoa";
            this.btn__Xoa.Size = new System.Drawing.Size(55, 24);
            this.btn__Xoa.Text = "Xóa";
            // 
            // btn__Thoat
            // 
            this.btn__Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn__Thoat.Image")));
            this.btn__Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__Thoat.Name = "btn__Thoat";
            this.btn__Thoat.Size = new System.Drawing.Size(67, 24);
            this.btn__Thoat.Text = "Thoát";
            // 
            // btnPhanGiaoVien
            // 
            this.btnPhanGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanGiaoVien.Image")));
            this.btnPhanGiaoVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPhanGiaoVien.Name = "btnPhanGiaoVien";
            this.btnPhanGiaoVien.Size = new System.Drawing.Size(126, 24);
            this.btnPhanGiaoVien.Text = "Phân giáo viên";
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
            this.btnThoat.Location = new System.Drawing.Point(972, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(50, 50);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frm_QuanLyGiaoVienChuNhiem_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 525);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QuanLyGiaoVienChuNhiem_Main";
            this.Text = "Frm_QuanLyGiaoVienChuNhiem_Main";
            this.pnlTitle.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btn__Thoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.ToolStripButton btnPhanGiaoVien;
    }
}
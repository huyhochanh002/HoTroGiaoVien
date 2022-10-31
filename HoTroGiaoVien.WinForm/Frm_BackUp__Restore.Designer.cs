namespace HoTroGiaoVien.WinForm
{
    partial class Frm_BackUp__Restore
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new HoTroGiaoVien.Commons.WaterMarkTextBox();
            this.btnChonfile = new HoTroGiaoVien.Commons.CircleButton();
            this.ckSaoLuu = new System.Windows.Forms.CheckBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnThucHien = new HoTroGiaoVien.Commons.CircleButton();
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
            this.pnlTitle.Controls.Add(this.btnThoat);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(804, 50);
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
            this.label1.Size = new System.Drawing.Size(704, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sao lưu - Phục hồi";
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
            this.btnThoat.Location = new System.Drawing.Point(754, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(50, 50);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 159);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(800, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(4, 109);
            this.label3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(4, 109);
            this.label2.TabIndex = 10;
            // 
            // txtPath
            // 
            this.txtPath.BackColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtPath.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtPath.Location = new System.Drawing.Point(11, 65);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(624, 36);
            this.txtPath.TabIndex = 11;
            this.txtPath.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPath.WaterMarkText = "Chọn đường dẫn";
            // 
            // btnChonfile
            // 
            this.btnChonfile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChonfile.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChonfile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChonfile.BorderRadius = 10;
            this.btnChonfile.BorderSize = 0;
            this.btnChonfile.FlatAppearance.BorderSize = 0;
            this.btnChonfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonfile.ForeColor = System.Drawing.Color.White;
            this.btnChonfile.Location = new System.Drawing.Point(640, 65);
            this.btnChonfile.Name = "btnChonfile";
            this.btnChonfile.Size = new System.Drawing.Size(150, 36);
            this.btnChonfile.TabIndex = 12;
            this.btnChonfile.Text = "Chọn file";
            this.btnChonfile.TextColor = System.Drawing.Color.White;
            this.btnChonfile.UseVisualStyleBackColor = false;
            this.btnChonfile.Click += new System.EventHandler(this.btnChonfile_Click);
            // 
            // ckSaoLuu
            // 
            this.ckSaoLuu.AutoSize = true;
            this.ckSaoLuu.Checked = true;
            this.ckSaoLuu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSaoLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSaoLuu.Location = new System.Drawing.Point(417, 114);
            this.ckSaoLuu.Name = "ckSaoLuu";
            this.ckSaoLuu.Size = new System.Drawing.Size(217, 33);
            this.ckSaoLuu.TabIndex = 13;
            this.ckSaoLuu.Text = "Backup database";
            this.ckSaoLuu.UseVisualStyleBackColor = true;
            this.ckSaoLuu.CheckedChanged += new System.EventHandler(this.ckSaoLuu_CheckedChanged);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.BackColor = System.Drawing.SystemColors.Control;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(131)))));
            this.lblThongBao.Location = new System.Drawing.Point(11, 104);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(31, 29);
            this.lblThongBao.TabIndex = 14;
            this.lblThongBao.Text = "...";
            // 
            // btnThucHien
            // 
            this.btnThucHien.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThucHien.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThucHien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThucHien.BorderRadius = 10;
            this.btnThucHien.BorderSize = 0;
            this.btnThucHien.FlatAppearance.BorderSize = 0;
            this.btnThucHien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.ForeColor = System.Drawing.Color.White;
            this.btnThucHien.Location = new System.Drawing.Point(640, 107);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(150, 40);
            this.btnThucHien.TabIndex = 15;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.TextColor = System.Drawing.Color.White;
            this.btnThucHien.UseVisualStyleBackColor = false;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // Frm_BackUp__Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 181);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.ckSaoLuu);
            this.Controls.Add(this.btnChonfile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BackUp__Restore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BackUp__Restore";
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
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Commons.WaterMarkTextBox txtPath;
        private Commons.CircleButton btnChonfile;
        private System.Windows.Forms.CheckBox ckSaoLuu;
        private System.Windows.Forms.Label lblThongBao;
        private Commons.CircleButton btnThucHien;
    }
}
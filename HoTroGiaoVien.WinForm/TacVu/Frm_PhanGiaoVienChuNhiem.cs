using HoTroGiaoVien.BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroGiaoVien.WinForm.TacVu
{
    public partial class Frm_PhanGiaoVienChuNhiem : Form
    {
        public Frm_PhanGiaoVienChuNhiem()
        {
            InitializeComponent();
        }
        public string MaGiaoVien = string.Empty;

        BLL_GiaoVien db;
        DataTable dtLop;

        string err = string.Empty;
        private void Frm_PhanGiaoVienChuNhiem_Load(object sender, EventArgs e)
        {
            db = new BLL_GiaoVien(ClsMain.arrayPath, ClsMain.fileType);

            LoadCboGiaoVien();
            if (!string.IsNullOrEmpty(MaGiaoVien))
            {
                cboGiaoVien.SelectedValue = MaGiaoVien;
            }
            HienThiDanhSachLop();
        }

        private void LoadCboGiaoVien()
        {
            DataTable dt = new DataTable(); ;
            dt = db.GetGiaoVienToCombo(ref err);

            cboGiaoVien.DataSource = dt;

            cboGiaoVien.ValueMember = "MaGiaoVien";
            cboGiaoVien.DisplayMember = "HoTenGiaoVien";

            cboGiaoVien.SelectedIndex = -1;
            cboGiaoVien.Text = "---Chọn giáo viên---";
        }

        private void HienThiDanhSachLop()
        {
            try
            {
                dtLop = new DataTable();
                dtLop = db.GetDanhSachLop(ref err);
                dgvDanhSachLop.DataSource = dtLop;
                for (int i = 0; i < dtLop.Rows.Count; i++)
                {
                    if (dgvDanhSachLop.Rows[i].Cells["colTenGiaoVien"].Value.ToString().Equals("Chưa có"))
                    {
                        DataGridViewCellStyle toMauNen = new DataGridViewCellStyle();
                        toMauNen.BackColor = Color.HotPink;
                        dgvDanhSachLop.Rows[i].DefaultCellStyle = toMauNen;
                    }
                }
                lblErr.Text = String.Format("Số lượng lớp: {0}", dtLop.Rows.Count);
            }
            catch (Exception ex)
            {

                lblErr.Text = ex.Message;
            }


        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (cboGiaoVien.SelectedIndex >= 0)
            {
                for (int i = 0; i < dgvDanhSachLop.RowCount; i++)
                {
                    if (dgvDanhSachLop.Rows[i].Cells["colCheck"].Value.ToString().Equals("1") || dgvDanhSachLop.Rows[i].Cells["colCheck"].Value.ToString().Equals("True"))
                    {
                        if (db.SavePhanCongGiaoVien(ref err, dgvDanhSachLop.Rows[i].Cells["colMaLop"].Value.ToString(), cboGiaoVien.SelectedValue.ToString()))
                        {
                            MessageBox.Show("Giáo viên đã được phân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HienThiDanhSachLop();
                        }
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

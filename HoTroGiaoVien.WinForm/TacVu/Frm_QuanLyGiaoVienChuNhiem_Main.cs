using System;
using System.Data;
using System.Windows.Forms;
using HoTroGiaoVien.BussinessLayer;
using HoTroGiaoVien.DAO.EF;

namespace HoTroGiaoVien.WinForm.TacVu
{
    public partial class Frm_QuanLyGiaoVienChuNhiem_Main : Form
    {
        public Frm_QuanLyGiaoVienChuNhiem_Main()
        {
            InitializeComponent();
        }
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        BLL_GiaoVien db;

        string err = string.Empty;
        DataTable dtGiaoVien;
        private void Frm_QuanLyGiaoVienChuNhiem_Main_Load(object sender, EventArgs e)
        {
            db = new BLL_GiaoVien(ClsMain.arrayPath, ClsMain.fileType);
            HienThiDanhSachGiaoVien();
        }

        private void HienThiDanhSachGiaoVien()
        {
            try
            {
                dtGiaoVien = new DataTable();
                dtGiaoVien = db.GetGiaoVienList(ref err);

                dgvGiaoVien.DataSource = dtGiaoVien.DefaultView;

                lblErr.Text = string.Format("Số lượng giáo viên: {0}", dtGiaoVien.Rows.Count);
            }
            catch (Exception ex)
            {
                lblErr.Text = ex.Message;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DongTab();
        }

        private void btn__NapLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachGiaoVien();
        }

        private void btn__Them_Click(object sender, EventArgs e)
        {
            Frm_QuanLyGiaoVienChuNhiem_Modified frm_QuanLyGiaoVienChuNhiem_Modified = new Frm_QuanLyGiaoVienChuNhiem_Modified();
            frm_QuanLyGiaoVienChuNhiem_Modified.isAdd = true;
            frm_QuanLyGiaoVienChuNhiem_Modified.ShowDialog();
            HienThiDanhSachGiaoVien();
        }
        string maGiaoVien = string.Empty;
        private void btnPhanGiaoVien_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maGiaoVien))
            {
                Frm_PhanGiaoVienChuNhiem frm_PhanGiaoVienChuNhiem = new Frm_PhanGiaoVienChuNhiem();
                frm_PhanGiaoVienChuNhiem.MaGiaoVien = maGiaoVien;
                frm_PhanGiaoVienChuNhiem.ShowDialog();
                maGiaoVien = string.Empty;
            }

        }

        private void dgvGiaoVien_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.Rows.Count > 0)
            {
                maGiaoVien = dgvGiaoVien.CurrentRow.Cells["colMaGiaoVien"].Value.ToString();
                giaoVien = new GiaoVien()
                {
                    MaGiaoVien = dgvGiaoVien.CurrentRow.Cells["colMaGiaoVien"].Value.ToString(),
                    HoGiaoVien = dgvGiaoVien.CurrentRow.Cells["colHoGiaoVien"].Value.ToString(),
                    TenGiaoVien = dgvGiaoVien.CurrentRow.Cells["colTenGiaoVien"].Value.ToString(),
                    DienThoai = dgvGiaoVien.CurrentRow.Cells["colDienThoai"].Value.ToString(),
                    Email = dgvGiaoVien.CurrentRow.Cells["colEmail"].Value.ToString(),
                    Facebook = dgvGiaoVien.CurrentRow.Cells["colFacebook"].Value.ToString(),
                    Zalo = dgvGiaoVien.CurrentRow.Cells["colZalo"].Value.ToString(),
                    DiaChi = dgvGiaoVien.CurrentRow.Cells["colDiaChi"].Value.ToString(),
                    MaKhoa = dgvGiaoVien.CurrentRow.Cells["colMaKhoa"].Value.ToString(),
                    MaNguoiDung = dgvGiaoVien.CurrentRow.Cells["colMaNguoiDung"].Value.ToString()
                };
            }
        }
        GiaoVien giaoVien = null;
        private void btn__Sua_Click(object sender, EventArgs e)
        {
            if (giaoVien != null)
            {
                Frm_QuanLyGiaoVienChuNhiem_Modified frm_QuanLyGiaoVienChuNhiem_Modified = new Frm_QuanLyGiaoVienChuNhiem_Modified();
                frm_QuanLyGiaoVienChuNhiem_Modified.isAdd = false;
                frm_QuanLyGiaoVienChuNhiem_Modified.giaoVien = giaoVien;
                frm_QuanLyGiaoVienChuNhiem_Modified.ShowDialog();
                giaoVien = null;
                HienThiDanhSachGiaoVien();
            }
        }

        private void btn__Xoa_Click(object sender, EventArgs e)
        {
            if (giaoVien != null)
            {
                if (db.DeleteGiaoVien(ref err, giaoVien.MaGiaoVien))
                {
                    MessageBox.Show("Xóa giáo viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSachGiaoVien();
                }
                else
                {
                    MessageBox.Show("Xóa giáo viên không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn giáo viên cần xóa\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

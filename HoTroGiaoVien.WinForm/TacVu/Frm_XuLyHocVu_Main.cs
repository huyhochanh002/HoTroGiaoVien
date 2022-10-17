using HoTroGiaoVien.BussinessLayer.TacVu;
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
    public partial class Frm_XuLyHocVu_Main : Form
    {
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;

        BLL_HoSoSinhVien db;
        public Frm_XuLyHocVu_Main()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DongTab();
        }

        private void btn__NapLai_Click(object sender, EventArgs e)
        {
            DislayChiTietXuLyHocVu(ClsMain.giaoVien.MaGiaoVien);
        }
        DataTable dtChiTietXuLyHocVu;
        string err = string.Empty;
        private void DislayChiTietXuLyHocVu(string maGiaoVien)
        {
            dtChiTietXuLyHocVu = new DataTable();
            dtChiTietXuLyHocVu = db.GetChiTietXyLyHocVuByGiaoVien(ref err,maGiaoVien);

            dgvChiTietXuLyHocVu.DataSource = dtChiTietXuLyHocVu.DefaultView;
        }

        private void Frm_XuLyHocVu_Main_Load(object sender, EventArgs e)
        {
            db = new BLL_HoSoSinhVien(ClsMain.arrayPath, ClsMain.fileType);
            DislayChiTietXuLyHocVu(ClsMain.giaoVien.MaGiaoVien);

            LoadCboLop();
        }

        private void LoadCboLop()
        {
            DataTable dt = new DataTable();
            dt = db.GetDataCboLop(ref err,ClsMain.giaoVien.MaGiaoVien);

            cboLop.DataSource = dt;

            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "TenLop";

            cboLop.SelectedIndex = -1;
            cboLop.Text = "--- Chọn lớp ---";
            statusLop = true;
        }

        bool statusLop = false;
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedIndex > -1 && statusLop == true)
            {
                DataView dataView = dtChiTietXuLyHocVu.DefaultView;
                if (cboLop.SelectedValue.ToString().Equals("0"))
                {
                    dataView.RowFilter = "";
                }
                else
                {
                    dataView.RowFilter = string.Format("MaLop = '{0}'", cboLop.SelectedValue.ToString());
                }
                dgvChiTietXuLyHocVu.DataSource = dataView;
            }
        }
        string maSinhVien = string.Empty;
        private void btn__Sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVien))
            {
                Frm_Profile_SinhVien frm_Profile_SinhVien = new Frm_Profile_SinhVien();
                frm_Profile_SinhVien.openFromHomePage = true;
                frm_Profile_SinhVien.maSinhVien = maSinhVien;
                frm_Profile_SinhVien.ShowDialog();
                maSinhVien = string.Empty;
                DislayChiTietXuLyHocVu(ClsMain.giaoVien.MaGiaoVien);
            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvChiTietXuLyHocVu_Click(object sender, EventArgs e)
        {
            if( dgvChiTietXuLyHocVu.Rows.Count>0)
            {
                maSinhVien = dgvChiTietXuLyHocVu.CurrentRow.Cells["colMaSinhVien"].Value.ToString();
            }
        }

        private void dgvChiTietXuLyHocVu_DoubleClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVien))
            {
                Frm_Profile_SinhVien frm_Profile_SinhVien = new Frm_Profile_SinhVien();
                frm_Profile_SinhVien.openFromHomePage = true;
                frm_Profile_SinhVien.maSinhVien = maSinhVien;
                frm_Profile_SinhVien.ShowDialog();
                maSinhVien = string.Empty;
                DislayChiTietXuLyHocVu(ClsMain.giaoVien.MaGiaoVien);
            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCapNhatNghiHoc_Click(object sender, EventArgs e)
        {
            //Kiem tra xem doi tuong sinh vien duoc chon hay chua
            if (!string.IsNullOrEmpty(maSinhVien))
            {

                //Sau khi xử lý cho nghi luôn
                if (db.UpdateTinhTrangSinhVien(ref err, maSinhVien, 3))
                {
                    MessageBox.Show(string.Format("Sinh viên {0} đa được thiết lập trạng thái cho nghỉ luôn", maSinhVien), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    DislayChiTietXuLyHocVu(ClsMain.giaoVien.MaGiaoVien);
                }
                else
                {
                    lblErr.Text = string.Format("Lỗi SQL : {0}", err);
                }

                //Nhớ thêm một phần ghi chú với nội dung là cho bảo lưu từ ngày nào...


            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên cần cập nhật trạng thái nghỉ luôn.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhatBaoLuu_Click(object sender, EventArgs e)
        {
            //Kiem tra xem doi tuong sinh vien duoc chon hay chua
            if (!string.IsNullOrEmpty(maSinhVien))
            {

                //Sau khi xử lý cho nghi luôn
                if (db.UpdateTinhTrangSinhVien(ref err, maSinhVien, 2))
                {
                    MessageBox.Show(string.Format("Sinh viên {0} đa được thiết lập trạng thái cho Bảo lưu", maSinhVien), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    DislayChiTietXuLyHocVu(ClsMain.giaoVien.MaGiaoVien);
                }
                else
                {
                    lblErr.Text = string.Format("Lỗi SQL : {0}", err);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên cần cập nhật trạng thái Bảo lưu.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btn__Thoat_Click(object sender, EventArgs e)
        {
            DongTab();
        }
    }
}

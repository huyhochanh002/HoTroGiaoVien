using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoTroGiaoVien.BussinessLayer.TacVu;

namespace HoTroGiaoVien.WinForm.TacVu
{
    public partial class Frm_HoSoHocSinh_Main : Form
    {
        public Frm_HoSoHocSinh_Main()
        {
            InitializeComponent();
        }
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        BLL_HoSoSinhVien bLL_HoSoSinhVien;
        DataTable dtDanhSachSinhVien;

        string err = string.Empty;
        bool statusLoad = false;

        private void Frm_HoSoHocSinh_Main_Load(object sender, EventArgs e)
        {
            bLL_HoSoSinhVien = new BLL_HoSoSinhVien(ClsMain.arrayPath, ClsMain.fileType);
            LoadComboLop();
            HienThiDanhSachSinhVienTheoLop(ClsMain.giaoVien.MaGiaoVien);//Chinh lai theo thong tin dang nhap
        }
        /// <summary>
        /// Phương thức Load combolop
        /// </summary>
        private void LoadComboLop()
        {
            DataTable _dataTable = new DataTable();
            _dataTable = bLL_HoSoSinhVien.LayDuLieuChoComboLop(ref err, "0");//Sẽ phải thay lại khi có xác nhận đăng nhập

            cboLop.DataSource = _dataTable;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            cboLop.SelectedIndex = -1;
            cboLop.Text = "---Chọn lớp---";
            statusLoad = true;

        }

        private void HienThiDanhSachSinhVienTheoLop(string maGiaoVien)
        {
            if (ClsMain.giaoVien.MaNhom.Equals("1"))
            {
                dtDanhSachSinhVien = bLL_HoSoSinhVien.LayDanhSachSinhVienTheoGiaoVien(ref err, "0");
                dgvDanhsachSinhVien.DataSource = dtDanhSachSinhVien.DefaultView;
            }
            else
            {
                dtDanhSachSinhVien = bLL_HoSoSinhVien.LayDanhSachSinhVienTheoGiaoVien(ref err, maGiaoVien);
                dgvDanhsachSinhVien.DataSource = dtDanhSachSinhVien.DefaultView;
            }
            for (int i = 0; i < dgvDanhsachSinhVien.Rows.Count; i++)
            {
                if(dgvDanhsachSinhVien.Rows[i].Cells["colTinhTrang"].Value.ToString().Equals("2"))
                {
                    dgvDanhsachSinhVien.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgvDanhsachSinhVien.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dgvDanhsachSinhVien.Rows[i].Cells["colTinhTrang"].Value.ToString().Equals("3"))
                {
                    dgvDanhsachSinhVien.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgvDanhsachSinhVien.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }   
            }
            lblQuantity.Text = string.Format("{0:#,###0}", dgvDanhsachSinhVien.Rows.Count);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DongTab();
        }

        private void btn__Them_Click(object sender, EventArgs e)
        {
            Frm_HoSoHocSinh_Modified frm_HoSoHocSinh_Modified = new Frm_HoSoHocSinh_Modified();
            frm_HoSoHocSinh_Modified.isAdd = true;
            frm_HoSoHocSinh_Modified.ShowDialog();
        }

        private void btn__Sua_Click(object sender, EventArgs e)
        {
            if (true)
            {
                Frm_HoSoHocSinh_Modified frm_HoSoHocSinh_Modified = new Frm_HoSoHocSinh_Modified();
                frm_HoSoHocSinh_Modified.isAdd = false;
                //Truyen them doi tuong sinh vien duoc chon


                frm_HoSoHocSinh_Modified.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên cần chỉnh sửa thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btn__Xoa_Click(object sender, EventArgs e)
        {
            //Kiem tra xem doi tuong sinh vien duoc chon hay chua
            if (true)
            {

            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên cần xóa thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnBaoLuu_Click(object sender, EventArgs e)
        {
            //Kiem tra xem doi tuong sinh vien duoc chon hay chua
            if (!string.IsNullOrEmpty(maSinhVien))
            {

                //Sau khi xử lý cho nghi luôn
                if (bLL_HoSoSinhVien.UpdateTinhTrangSinhVien(ref err, maSinhVien, 2))
                {
                    MessageBox.Show(string.Format("Sinh viên {0} đa được thiết lập trạng thái cho Bảo lưu", maSinhVien), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    HienThiDanhSachSinhVienTheoLop(ClsMain.giaoVien.MaGiaoVien);
                }
                else
                {
                    lblErr.Text = string.Format("Lỗi SQL : {0}", err);
                }

                //Nhớ thêm một phần ghi chú với nội dung là cho bảo lưu từ ngày nào...


            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên cần cập nhật trạng thái Bảo lưu.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnChoNghiLuon_Click(object sender, EventArgs e)
        {
            //Kiem tra xem doi tuong sinh vien duoc chon hay chua
            if (!string.IsNullOrEmpty(maSinhVien))
            {

                //Sau khi xử lý cho nghi luôn
                if (bLL_HoSoSinhVien.UpdateTinhTrangSinhVien(ref err, maSinhVien, 3))
                {
                    MessageBox.Show(string.Format("Sinh viên {0} đa được thiết lập trạng thái cho nghỉ luôn", maSinhVien), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    HienThiDanhSachSinhVienTheoLop(ClsMain.giaoVien.MaGiaoVien);
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

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv=null;//= dtDanhSachSinhVien.DefaultView;
            if (cboLop.SelectedIndex >0 && statusLoad)
            {
                dv = dtDanhSachSinhVien.DefaultView;
                dv.RowFilter = string.Format("MaLop = '{0}'", cboLop.SelectedValue.ToString());
               
            }else if(cboLop.SelectedIndex ==0 && statusLoad)
            {
                dv = dtDanhSachSinhVien.DefaultView;
                dv.RowFilter = "";
            }
            dgvDanhsachSinhVien.DataSource = dv;
        }

        private void btnGhiChuThongTin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVien))
            {
                Frm_Profile_SinhVien frm_Profile_SinhVien = new Frm_Profile_SinhVien();
                frm_Profile_SinhVien.openFromHomePage = true;
                frm_Profile_SinhVien.maSinhVien = maSinhVien;
                frm_Profile_SinhVien.ShowDialog();
                HienThiDanhSachSinhVienTheoLop(ClsMain.giaoVien.MaGiaoVien);
            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVien))
            {
                Frm_Profile_SinhVien frm_Profile_SinhVien = new Frm_Profile_SinhVien();
                frm_Profile_SinhVien.openFromHomePage = true;
                frm_Profile_SinhVien.maSinhVien = maSinhVien;
                frm_Profile_SinhVien.ShowDialog();
                HienThiDanhSachSinhVienTheoLop(ClsMain.giaoVien.MaGiaoVien);
            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên xem xử lý học vụ.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        string maSinhVien = string.Empty;
        private void dgvDanhsachSinhVien_Click(object sender, EventArgs e)
        {
            if (dgvDanhsachSinhVien.Rows.Count > 0)
            {
                maSinhVien = dgvDanhsachSinhVien.CurrentRow.Cells["colMaSinhVien"].Value.ToString();
            }

        }

        private void dgvDanhsachSinhVien_DoubleClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVien))
            {
                Frm_Profile_SinhVien frm_Profile_SinhVien = new Frm_Profile_SinhVien();
                frm_Profile_SinhVien.openFromHomePage = true;
                frm_Profile_SinhVien.maSinhVien = maSinhVien;
                frm_Profile_SinhVien.ShowDialog();
            }
        }

        private void btn__NapLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachSinhVienTheoLop(ClsMain.giaoVien.MaGiaoVien);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVien))
            {
                Frm_Profile_SinhVien frm_Profile_SinhVien = new Frm_Profile_SinhVien();
                frm_Profile_SinhVien.openFromHomePage = true;
                frm_Profile_SinhVien.maSinhVien = maSinhVien;
                frm_Profile_SinhVien.ShowDialog();
                HienThiDanhSachSinhVienTheoLop(ClsMain.giaoVien.MaGiaoVien);
            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên xem xử lý học vụ.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVien))
            {
                Frm_Profile_SinhVien frm_Profile_SinhVien = new Frm_Profile_SinhVien();
                frm_Profile_SinhVien.openFromHomePage = true;
                frm_Profile_SinhVien.maSinhVien = maSinhVien;
                frm_Profile_SinhVien.ShowDialog();
                HienThiDanhSachSinhVienTheoLop(ClsMain.giaoVien.MaGiaoVien);
            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}

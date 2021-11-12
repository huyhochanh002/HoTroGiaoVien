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
            bLL_HoSoSinhVien = new BLL_HoSoSinhVien(ClsMain.arrayPath,ClsMain.fileType);
            LoadComboLop();
            HienThiDanhSachSinhVienTheoLop("0");//Chinh lai theo thong tin dang nhap
        }

        private void LoadComboLop()
        {
            DataTable dataTable = new DataTable();
            dataTable = bLL_HoSoSinhVien.LayDuLieuChoComboLop(ref err, "0");//Sẽ phải thay lại khi có xác nhận đăng nhập

            cboLop.DataSource = dataTable;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            cboLop.SelectedIndex = -1;
            cboLop.Text = "---Chọn lớp---";
            statusLoad = true;

        }
    
        private void HienThiDanhSachSinhVienTheoLop(string maGiaoVien)
        {
            dtDanhSachSinhVien = bLL_HoSoSinhVien.LayDanhSachSinhVienTheoGiaoVien(ref err, maGiaoVien);
            dgvDanhsachSinhVien.DataSource = dtDanhSachSinhVien.DefaultView;
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
            if(true)
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
            if (true)
            {

                //Sau khi xử lý cho bảo lưu

               //Nhớ thêm một phần ghi chú với nội dung là cho bảo lưu từ ngày nào...
                MessageBox.Show("Sinh viên {} đa được thiết lập trạng thái Bào lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên cần bảo lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnChoNghiLuon_Click(object sender, EventArgs e)
        {
            //Kiem tra xem doi tuong sinh vien duoc chon hay chua
            if (true)
            {

                //Sau khi xử lý cho nghi luôn

                //Nhớ thêm một phần ghi chú với nội dung là cho bảo lưu từ ngày nào...
                MessageBox.Show("Sinh viên {} đa được thiết lập trạng thái cho nghỉ luôn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên cần cập nhật trạng thái nghỉ luôn.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedIndex > -1 && statusLoad )
            {
               //Thuc hien loc tren dataview
            }
        }

        private void btnGhiChuThongTin_Click(object sender, EventArgs e)
        {
            Frm_GhiChu_ThongTin frm = new Frm_GhiChu_ThongTin();
            frm.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Frm_Profile_SinhVien frm = new Frm_Profile_SinhVien();
            frm.ShowDialog();
        }
    }
}

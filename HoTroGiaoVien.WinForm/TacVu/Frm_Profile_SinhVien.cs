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
    public partial class Frm_Profile_SinhVien : Form
    {
        public Frm_Profile_SinhVien()
        {
            InitializeComponent();
        }

        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        public string maSinhVien=string.Empty;
        public bool openFromHomePage = false;
        private void btnThoat_Click(object sender, EventArgs e)
        {
           if(true)
            {
                this.Close();
            }
        }
        DataTable dtThongTinProfile;
        BLL_HoSoSinhVien db;
        string err = string.Empty;
        private void Frm_Profile_SinhVien_Load(object sender, EventArgs e)
        {
            if(openFromHomePage)
            {
                db = new BLL_HoSoSinhVien(ClsMain.arrayPath, ClsMain.fileType);
                HienThiThongTinProfileByMaSinhVien(maSinhVien);
                HienThiLichSuGhiChuCuaSinhVien(maSinhVien);
            }
        }

        private void HienThiLichSuGhiChuCuaSinhVien(string maSinhVien)
        {
            
        }

        private void HienThiThongTinProfileByMaSinhVien(string maSinhVien)
        {
            dtThongTinProfile = new DataTable();
            dtThongTinProfile = db.LayThongTinCaNhanSinhVien(ref err, maSinhVien);
            if(dtThongTinProfile.Rows.Count>0)
            {
                SetStudentValueToControl(dtThongTinProfile);
            }
        }

        private void SetStudentValueToControl(DataTable dtThongTinProfile)
        {
            lblTitle.Text = string.Format("HỒ SƠ CHỦ NHIỆM CỦA SINH VIÊN {0}", dtThongTinProfile.Rows[0]["HoTenSinhVien"].ToString().ToUpper());
            lblHoSinhVien.Text =string.Format("{0}", dtThongTinProfile.Rows[0]["HoSinhVien"].ToString());
            lblTenSinhVien.Text = string.Format("{0}", dtThongTinProfile.Rows[0]["TenSinhVien"].ToString());
            lblLop.Text = string.Format("Lớp: {0}", dtThongTinProfile.Rows[0]["MaLop"].ToString());
            lblSoDienThoai.Text = string.Format("Điện thoại: {0}", dtThongTinProfile.Rows[0]["DienThoai"].ToString());
            lblZalo.Text = string.Format("Zalo: {0}", dtThongTinProfile.Rows[0]["Zalo"].ToString());
            lblFacebook.Text = string.Format("Facebook: {0}", dtThongTinProfile.Rows[0]["FaceBook"].ToString());
            lblEmail.Text = string.Format("Email: {0}", dtThongTinProfile.Rows[0]["Email"].ToString());
            lblTinhTrang.Text = string.Format("Tình trạng: {0}", dtThongTinProfile.Rows[0]["TinhTrang"].ToString());
            lblDiaChi.Text = string.Format("Địa chỉ: {0}", dtThongTinProfile.Rows[0]["DiaChi"].ToString());
            if (!string.IsNullOrEmpty(dtThongTinProfile.Rows[0]["HinhDaiDien"].ToString()) && dtThongTinProfile.Rows[0]["HinhDaiDien"].ToString() != " ")
            {
                picHinhDaiDien.Image = Image.FromFile(dtThongTinProfile.Rows[0]["HinhDaiDien"].ToString());
            }
            else
            {

                picHinhDaiDien.Image = Image.FromFile(ClsMain.hinhDaiDienNull);
            }

            lblLop.Text = string.Format("Lớp: {0}", dtThongTinProfile.Rows[0]["MaLop"].ToString());
        }

        private void btn__ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            if (pnlThongTinCaNhan.Height == 299)
            {
                pnlThongTinCaNhan.Height = 36;
            }
            else
            {
                pnlThongTinCaNhan.Height = 299;
                pnl__ThongTinGiaDinh.Height = 36;
                pnl__KetQuaHocTap.Height = 36;
            }
        }
        DataTable dtThongTinGiaDinh=null;
        private void btn__QuanHeGiaDinh_Click(object sender, EventArgs e)
        {
            if (pnl__ThongTinGiaDinh.Height == 299)
            {
                if(dtThongTinGiaDinh==null)
                {
                    dtThongTinGiaDinh = new DataTable();
                    dtThongTinGiaDinh = db.LayThongTinGiaDinhTheoMaSinhVien(ref err, maSinhVien);
                    dgvThongTinGiaDinh.DataSource = dgvThongTinGiaDinh;
                }   
                pnl__ThongTinGiaDinh.Height = 36;
            }
            else
            {
                pnl__ThongTinGiaDinh.Height = 299;
                pnlThongTinCaNhan.Height = 36;
                pnl__KetQuaHocTap.Height = 36;
            }
        }

        private void btnKetQuaHocTap_Click(object sender, EventArgs e)
        {
            if (pnl__KetQuaHocTap.Height == 299)
            {
                pnl__KetQuaHocTap.Height = 36;
            }
            else
            {
                pnl__KetQuaHocTap.Height = 299;
                pnlThongTinCaNhan.Height = 36;
                pnl__ThongTinGiaDinh.Height = 36;
            }
        }
        DataTable dtLichSuGhiChu = null;
        DataTable dtXuLyHocVu = null;
        DataTable dtNoiNgoaiTru = null;
        DataTable dtSoThichSinhVien = null;

        private void tabControlMain_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            switch (tabControlMain.SelectedTabIndex)
            {
                case 0:
                    //Lịch sử ghi chú
                    MessageBox.Show("Xem lịch sử nghi chú");
                    break;
                case 1:
                    MessageBox.Show("Xem Xử lý học vụ");
                    break;
                case 2:
                    MessageBox.Show("Xem Thong tin nội ngoại trú");
                    break;
                case 3:
                    MessageBox.Show("Xem Sở thích của sinh viên");
                    break;
                default:
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pnlThem.Visible = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnlThem.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

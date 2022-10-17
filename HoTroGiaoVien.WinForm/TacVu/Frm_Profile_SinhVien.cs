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
        //---Begin khai báo biến để mở form theo dạng tab
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        //----End -------------

        public string maSinhVien = string.Empty;
        public bool openFromHomePage = false;
        DataTable dtThongTinProfile;

        BLL_HoSoSinhVien db;
        string err = string.Empty;

        private void Frm_Profile_SinhVien_Load(object sender, EventArgs e)
        {
            if (openFromHomePage)
            {
                db = new BLL_HoSoSinhVien(ClsMain.arrayPath, ClsMain.fileType);
                HienThiThongTinProfileByMaSinhVien(maSinhVien);
                DisplayChiTietGhiChu(maSinhVien);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (true)
            {
                this.Close();
            }
        }
        private void HienThiThongTinProfileByMaSinhVien(string maSinhVien)
        {
            dtThongTinProfile = new DataTable();
            dtThongTinProfile = db.LayThongTinCaNhanSinhVien(ref err, maSinhVien);
            if (dtThongTinProfile.Rows.Count > 0)
            {
                SetStudentValueToControl(dtThongTinProfile);
            }
        }

        private void SetStudentValueToControl(DataTable dtThongTinProfile)
        {
            lblTitle.Text = string.Format("HỒ SƠ CHỦ NHIỆM CỦA SINH VIÊN {0} -MSSV: {1}", dtThongTinProfile.Rows[0]["HoTenSinhVien"].ToString().ToUpper(),maSinhVien);
            lblHoSinhVien.Text = string.Format("{0}", dtThongTinProfile.Rows[0]["HoSinhVien"].ToString());
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
        DataTable dtThongTinGiaDinh = null;
        private void btn__QuanHeGiaDinh_Click(object sender, EventArgs e)
        {
            if (pnl__ThongTinGiaDinh.Height == 299)
            {
                if (dtThongTinGiaDinh == null)
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
                    ////Lịch sử ghi chú
                    //MessageBox.Show("Xem lịch sử nghi chú");
                    DisplayChiTietGhiChu(maSinhVien);
                    break;
                case 1:
                    LoadComboHocKy();
                    LoadComboLoaiXuLyHocVu();
                    DislayChiTietXuLyHocVu(maSinhVien);
                    break;
                case 2:
                    DisplayChiTietNoiNgoaiTru(maSinhVien);
                    break;
                case 3:
                    DislayChiTietSoThich(maSinhVien);
                    break;
                default:
                    break;
            }
        }

        private void DisplayChiTietNoiNgoaiTru(string maSinhVien)
        {
            dtNoiNgoaiTru = new DataTable();
            dtNoiNgoaiTru = db.GetChiTietNoiNgoaiTru(ref err, maSinhVien);

            dgvChiTietNoiNgoaiTru.DataSource = dtNoiNgoaiTru.DefaultView;
        }

        private void DislayChiTietSoThich(string maSinhVien)
        {
            dtSoThichSinhVien = new DataTable();
            dtSoThichSinhVien = db.GetChiTietSoThich(ref err, maSinhVien);
            dgvSoThichSinhVien.DataSource = dtSoThichSinhVien.DefaultView;
        }

        private void LoadComboLoaiXuLyHocVu()
        {

            DataTable dtLoaiXuLyHocVu = new DataTable();
            dtLoaiXuLyHocVu = db.GetLoaiXuLy(ref err);

            cboLoaiXuLyHocVu.DataSource = dtLoaiXuLyHocVu;

            cboLoaiXuLyHocVu.DisplayMember = "TenLoaiXuLy";
            cboLoaiXuLyHocVu.ValueMember = "MaLoaiXuLy";

            cboLoaiXuLyHocVu.SelectedIndex = -1;
            cboLoaiXuLyHocVu.Text = "Chọn loại xử lý";
        }

        private void LoadComboHocKy()
        {
            DataTable dtHocKy = new DataTable();
            dtHocKy = db.GetHocKy(ref err);

            cboHocKy.DataSource = dtHocKy;

            cboHocKy.DisplayMember = "TenHocKy";
            cboHocKy.ValueMember = "MaHocKy";

            cboHocKy.SelectedIndex = -1;
            cboHocKy.Text = "Chọn học kỳ ";
        }

        private void DisplayChiTietGhiChu(string maSinhVien)
        {
            dtLichSuGhiChu = db.GetChiTietGhiChu(ref err,maSinhVien);
            dgvDanhSachGhiChu.DataSource = dtLichSuGhiChu.DefaultView;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pnlThem.Visible = true;
            LoadCboTinh();
        }
        bool statusTinh = false;
        private void LoadCboTinh()
        {
            DataTable dtTinh = new DataTable();
            dtTinh = db.GetComboTinh(ref err);

            cboTinh.DataSource = dtTinh;

            cboTinh.DisplayMember = "TenTinh";
            cboTinh.ValueMember = "MaTinh";

            cboTinh.SelectedIndex = -1;
            cboTinh.Text = "--- Chọn tỉnh --- ";
            statusTinh = true;
        }
        bool statusHuyen = false;
        private void LoadCboHuyen(string maTinh)
        {
            DataTable dtHuyen = new DataTable();
            dtHuyen = db.GetComboHuyen(ref err,maTinh);

            cboQuanHuyen.DataSource = dtHuyen;

            cboQuanHuyen.DisplayMember = "TenQuanHuyen";
            cboQuanHuyen.ValueMember = "MaQuanHuyen";

            cboQuanHuyen.SelectedIndex = -1;
            cboQuanHuyen.Text = "--- Chọn Huyện --- ";
            statusHuyen = true;
        }
        bool statusPhuong = false;
        private void LoadCboPhuong(string maHuyen)
        {
            DataTable dtPhuong = new DataTable();
            dtPhuong = db.GetComboPhuong(ref err, maHuyen);

            cboPhuongXa.DataSource = dtPhuong;

            cboPhuongXa.DisplayMember = "TenPhuongXa";
            cboPhuongXa.ValueMember = "MaPhuongXa";

            cboPhuongXa.SelectedIndex = -1;
            cboPhuongXa.Text = "--- Chọn Phường --- ";
            statusPhuong = true;
        }

       
        private void ClosePanelNgoaiTru(bool statusClose)
        { 
            pnlThem.Visible = statusClose;
            statusTinh = statusClose;
            statusHuyen = statusClose;
            statusPhuong = statusClose;
            cboTinh.SelectedIndex = -1;
            cboTinh.Text = "--- Chọn tỉnh ---";

            cboQuanHuyen.SelectedIndex = -1;
            cboQuanHuyen.Text = "--- Chọn Huyện ---";

            cboPhuongXa.SelectedIndex = -1;
            cboPhuongXa.Text = "--- Chọn Phường ---";

            txtNoiCuTru.ResetText();
            txtDiaChi.ResetText();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClosePanelNgoaiTru(false);
        }
        string maNgoaiTru = "0";
        string phanLoai = "1";
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNoiCuTru.Text))
            {
                if(!string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    if(cboTinh.SelectedIndex>-1)
                    {
                        if(cboQuanHuyen.SelectedIndex>-1)
                        {
                            if(cboPhuongXa.SelectedIndex>-1)
                            {
                                if (rdoNoiTru.Checked == true)
                                {
                                    phanLoai = "1";
                                }
                                else if (rdoNgoaiTru.Checked == true) { 
                                    phanLoai = "2";
                                }
                                else
                                {
                                    phanLoai = "3";
                                }
                                if(db.InsertAndUpDateNgoaiTru(ref err,maSinhVien,maNgoaiTru,phanLoai,txtNoiCuTru.Text,txtDiaChi.Text,cboTinh.SelectedValue.ToString(),cboQuanHuyen.SelectedValue.ToString(),cboPhuongXa.SelectedValue.ToString()))
                                {
                                    MessageBox.Show("Successfull");
                                    ClosePanelNgoaiTru(false);
                                    DisplayChiTietNoiNgoaiTru(maSinhVien);
                                }
                                else
                                {
                                    lblErr.Text = string.Format("Lỗi SQL: {0}", err);
                                    lblErr.ForeColor = Color.Red;
                                    lblErr.BackColor = Color.White;
                                }
                            }
                        }
                    }
                }
            }
        }
        string maGhiChu = "0";
        
        private void btnThemGhiChu_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(maSinhVien))
            {
                if(!string.IsNullOrEmpty(ClsMain.giaoVien.MaGiaoVien))
                {
                    if (!string.IsNullOrEmpty(txtNoiDung.Text))
                    {
                        if (db.InsertAndUpdateGhiChu(ref err, maSinhVien, maGhiChu, txtNoiDung.Text, DateTime.Now, ClsMain.giaoVien.MaGiaoVien))
                        {
                            MessageBox.Show("Thêm thành công");
                            maGhiChu = "0";
                            DisplayChiTietGhiChu(maSinhVien);
                        }
                        else
                        {
                            lblErr.Text = string.Format("Lỗi SQL: {0}", err);
                            lblErr.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void dgvDanhSachGhiChu_Click(object sender, EventArgs e)
        {
            maGhiChu = dgvDanhSachGhiChu.CurrentRow.Cells["colMaGhiChu"].Value.ToString();
            txtNoiDung.Text= dgvDanhSachGhiChu.CurrentRow.Cells["colNoiDungGhiChu"].Value.ToString();
        }

        private void btnThemXuLyHocVu_Click(object sender, EventArgs e)
        {
            if(cboHocKy.SelectedIndex>=0)
            {
                if (cboLoaiXuLyHocVu.SelectedIndex >= 0)
                {
                    if(!string.IsNullOrEmpty(txtNoiDungLamViec.Text))
                    {
                        if(cboTinhTrangKetLuan.SelectedIndex>0)
                        {
                            if(db.InsertAndUpdateXuLyHocVu(ref err,maSinhVien,cboHocKy.SelectedValue.ToString(),dtpNgayLamViec.Value,cboLoaiXuLyHocVu.SelectedValue.ToString(),txtNoiDungLamViec.Text,cboTinhTrangKetLuan.Text))
                            {
                                MessageBox.Show("Thêm thành công");
                                DislayChiTietXuLyHocVu(maSinhVien);
                            }
                            else
                            {
                                lblErr.Text = string.Format("Lỗi SQL : {0}", err);
                                lblErr.ForeColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }

        private void DislayChiTietXuLyHocVu(string maSinhVien)
        {
            dtXuLyHocVu = new DataTable();
            dtXuLyHocVu = db.GetChiTietXuLyHocVu(ref err, maSinhVien);

            dgvXuLyHocVu.DataSource = dtXuLyHocVu.DefaultView;
        }

        private void btnHuyXuLyHocVu_Click(object sender, EventArgs e)
        {
            cboHocKy.SelectedIndex = -1;
            cboHocKy.Text = "Chọn học kỳ";

            cboLoaiXuLyHocVu.SelectedIndex = -1;
            cboLoaiXuLyHocVu.Text="Chọn loại xử lý";

            txtNoiDungLamViec.ResetText();
            dtpNgayLamViec.ResetText();

            cboTinhTrangKetLuan.SelectedIndex = 0;
        }

        private void dgvXuLyHocVu_Click(object sender, EventArgs e)
        {
            if(dgvXuLyHocVu.Rows.Count>0)
            {
                cboHocKy.SelectedValue = dgvXuLyHocVu.CurrentRow.Cells["colMaHocKy"].Value.ToString();
                cboLoaiXuLyHocVu.SelectedValue = dgvXuLyHocVu.CurrentRow.Cells["colMaLoaiXuLy"].Value.ToString();
                dtpNgayLamViec.Value = Convert.ToDateTime(dgvXuLyHocVu.CurrentRow.Cells["colNgayLamViec"].Value.ToString());
                txtNoiDungLamViec.Text= dgvXuLyHocVu.CurrentRow.Cells["colNoiDungLamViec"].Value.ToString();
                cboTinhTrangKetLuan.Text= dgvXuLyHocVu.CurrentRow.Cells["colKetLuan"].Value.ToString();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        string soLuong = "0";
        private void btnThemSoThich_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(maSinhVien))
            {
                if(!string.IsNullOrEmpty(txtSoThich.Text))
                {
                    if(db.InsertAndUpdateSoThich(ref err, maSinhVien, soLuong, txtSoThich.Text))
                    {
                        MessageBox.Show("Thêm thành công");
                        soLuong = "0";
                        DislayChiTietSoThich(maSinhVien);
                    }else
                    {
                        lblErr.Text = string.Format("Lỗi SQL : {0}", err);
                        lblErr.ForeColor = Color.Red;
                    }    
                }
            }
        }

        private void dgvSoThichSinhVien_Click(object sender, EventArgs e)
        {
            if( dgvSoThichSinhVien.Rows.Count>0)
            {
                soLuong = dgvSoThichSinhVien.CurrentRow.Cells["colSoLuong"].Value.ToString();
                txtSoThich.Text= dgvSoThichSinhVien.CurrentRow.Cells["colSoThich"].Value.ToString();
            }
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinh.SelectedIndex > -1 && statusTinh == true)
                LoadCboHuyen(cboTinh.SelectedValue.ToString());
        }

        private void cboQuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuanHuyen.SelectedIndex > -1 && statusHuyen == true)
               LoadCboPhuong(cboQuanHuyen.SelectedValue.ToString());
        }
        string maTinh, maHuyen, maPhuong;

        private void btnLayLaiDuLieu_Click(object sender, EventArgs e)
        {
            DisplayChiTietNoiNgoaiTru(maSinhVien);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnlThem.Visible = true;
            LoadCboTinh();
            cboTinh.SelectedValue = maTinh;
            LoadCboHuyen(maTinh);
            cboQuanHuyen.SelectedValue = maHuyen;
            LoadCboPhuong(maHuyen);
            cboPhuongXa.SelectedValue = maPhuong;
        }

        private void dgvChiTietNoiNgoaiTru_Click(object sender, EventArgs e)
        {
            if(dgvChiTietNoiNgoaiTru.Rows.Count>0)
            {
                if (dgvChiTietNoiNgoaiTru.CurrentRow.Cells["colPhanLoai"].Value.ToString().Equals("1")){
                    rdoNoiTru.Checked = true;
                }else if (dgvChiTietNoiNgoaiTru.CurrentRow.Cells["colPhanLoai"].Value.ToString().Equals("2"))
                {
                    rdoNgoaiTru.Checked = true;
                }
                else
                {
                    rdoOCungGiaDinh.Checked = true;
                }
                txtNoiCuTru.Text = dgvChiTietNoiNgoaiTru.CurrentRow.Cells["colNoiCuTru"].Value.ToString();
                txtDiaChi.Text = dgvChiTietNoiNgoaiTru.CurrentRow.Cells["colDiaChiCuTru"].Value.ToString();
               maTinh = dgvChiTietNoiNgoaiTru.CurrentRow.Cells["colTinh"].Value.ToString();
              maHuyen= dgvChiTietNoiNgoaiTru.CurrentRow.Cells["colQuanHuyen"].Value.ToString();
              maPhuong= dgvChiTietNoiNgoaiTru.CurrentRow.Cells["colPhuongXa"].Value.ToString();
                maNgoaiTru= dgvChiTietNoiNgoaiTru.CurrentRow.Cells["colMaNgoaiTru"].Value.ToString();
            }
        }
    }
}

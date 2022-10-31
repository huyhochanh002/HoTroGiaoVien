using DevComponents.DotNetBar;
using HoTroGiaoVien.WinForm.DanhMuc;
using HoTroGiaoVien.WinForm.TacVu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroGiaoVien.WinForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //Khai báo để tắt form trên form main
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;


        bool trangThaiMoTab = false;
        string tieuDeTab;

        private void FrmMain_Load(object sender, EventArgs e)
        {

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            LoadLayout();
            OpenForm(new Frm_HomePage(), "Home page", true);
            lblUserName.Text = string.Format("{0} {1} - [{2}]", ClsMain.giaoVien.HoGiaoVien, ClsMain.giaoVien.TenGiaoVien, ClsMain.giaoVien.MaGiaoVien);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = string.Format("{0:dd-MM-yyyy HH:mm:ss}", DateTime.Now);
        }
        private void LoadLayout()
        {
            //Hiển thị menu
            pnlHeThong.Height = 307;
            pnlDanhMuc.Height = 53;
            pnlTacVu.Height = 53;
            pnl__BaoCao.Height = 53;
            pnlRightSideBar.Width = 220;

            lblTimer.Text = string.Format("{0:dd-MM-yyyy HH:mm:ss}", DateTime.Now);
            timer1.Enabled = true;
        }

        private void btn__Menu__HeThong_Click(object sender, EventArgs e)
        {
            if (pnlHeThong.Height == 307)
            {
                pnlHeThong.Height = 53;
            }
            else
            {
                pnlHeThong.Height = 307;
                pnlRightSideBar.Width = 220;
                pnlDanhMuc.Height = 53;
                pnlTacVu.Height = 53;
                pnl__BaoCao.Height = 53;
            }
        }

        private void btn__Menu__DanhMuc_Click(object sender, EventArgs e)
        {
            if (pnlDanhMuc.Height == 307)
            {
                pnlDanhMuc.Height = 53;

            }
            else
            {
                pnlDanhMuc.Height = 307;
                pnlRightSideBar.Width = 220;
                pnlHeThong.Height = 53;
                pnlTacVu.Height = 53;
                pnl__BaoCao.Height = 53;
            }
        }

        private void btnMenu__TacVu_Click(object sender, EventArgs e)
        {
            if (pnlTacVu.Height == 307)
            {
                pnlTacVu.Height = 53;
            }
            else
            {
                pnl__BaoCao.Height = 53;
                pnlDanhMuc.Height = 53;
                pnlRightSideBar.Width = 220;
                pnlHeThong.Height = 53;
                pnlTacVu.Height = 307;
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (pnl__BaoCao.Height == 307)
            {
                pnl__BaoCao.Height = 53;

            }
            else
            {
                pnl__BaoCao.Height = 307;
                pnlDanhMuc.Height = 53;
                pnlRightSideBar.Width = 220;
                pnlHeThong.Height = 53;
                pnlTacVu.Height = 53;
            }
        }

        private void btn__Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            if (pnlRightSideBar.Width == 220)
            {
                pnlRightSideBar.Width = 53;
                pnlHeThong.Height = 53;
                pnlDanhMuc.Height = 53;
                pnlTacVu.Height = 53;
            }
            else
            {
                pnlRightSideBar.Width = 220;
            }
        }

        private void tc_Main_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            TabItem t = tc_Main.SelectedTab;
            tc_Main.Tabs.Remove(t);
        }

        private bool checkOpenTabs(string name)
        {
            for (int i = 0; i < tc_Main.Tabs.Count; i++)
            {
                if (tc_Main.Tabs[i].Text == name)
                {
                    tc_Main.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }


        private void DongTab()
        {
            foreach (TabItem item in tc_Main.Tabs)
            {
                if (item.IsSelected)
                {
                    tc_Main.Tabs.Remove(item);
                    return;
                }
            }
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Chương trình sẽ tắt\n Bạn có chắc chắn muốn thực hiện thao tác này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void OpenForm(Form frm, string tieuDe, bool trangThaiMoTab)
        {
            this.trangThaiMoTab = trangThaiMoTab;
            this.tieuDeTab = tieuDe;
            if (!checkOpenTabs(tieuDeTab))
            {
                TabItem t = tc_Main.CreateTab(tieuDeTab);
                t.Name = frm.Name;
                switch (frm.Name)
                {
                    case "Frm_HomePage":
                        frm = new Frm_HomePage() { DongTab = new Frm_HomePage._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "FrmQuanLyTaiKhoan_Main":
                        frm = new FrmQuanLyTaiKhoan_Main() { DongTab = new FrmQuanLyTaiKhoan_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "FrmThayDoiMatKhau_Main":
                        frm = new FrmThayDoiMatKhau_Main() { DongTab = new FrmThayDoiMatKhau_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "Frm_DanhMucKhoa_Main":
                        frm = new Frm_DanhMucKhoa_Main() { DongTab = new Frm_DanhMucKhoa_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "Frm_ChucVu_Main":
                        frm = new Frm_ChucVu_Main() { DongTab = new Frm_ChucVu_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "Frm_DanhMucLop_Main":
                        frm = new Frm_DanhMucLop_Main() { DongTab = new Frm_DanhMucLop_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "Frm_QuanHeGiaDinh_Main":
                        frm = new Frm_QuanHeGiaDinh_Main() { DongTab = new Frm_QuanHeGiaDinh_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "Frm_LoaiXuLyHocVu_Main":
                        frm = new Frm_LoaiXuLyHocVu_Main() { DongTab = new Frm_LoaiXuLyHocVu_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "Frm_NhomTaiKhoan_Main":
                        frm = new Frm_NhomTaiKhoan_Main() { DongTab = new Frm_NhomTaiKhoan_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "Frm_HoSoHocSinh_Main":
                        frm = new Frm_HoSoHocSinh_Main() { DongTab = new Frm_HoSoHocSinh_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "Frm_QuanLyGiaoVienChuNhiem_Main":
                        frm = new Frm_QuanLyGiaoVienChuNhiem_Main() { DongTab = new Frm_QuanLyGiaoVienChuNhiem_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "Frm_XuLyHocVu_Main":
                        frm = new Frm_XuLyHocVu_Main() { DongTab = new Frm_XuLyHocVu_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "Frm_QuanLyHocTap_Main":
                        frm = new Frm_QuanLyHocTap_Main() { DongTab = new Frm_QuanLyHocTap_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                    case "Frm_QuanLyNoiNgoaiTru_Main":
                        frm = new Frm_QuanLyNoiNgoaiTru_Main() { DongTab = new Frm_QuanLyNoiNgoaiTru_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;
                    case "Frm_BackUp__Restore":
                        frm = new Frm_BackUp__Restore() { DongTab = new Frm_BackUp__Restore._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;
                    case "Frm_PhanQuyen_Main":
                        frm = new Frm_PhanQuyen_Main() { DongTab = new Frm_PhanQuyen_Main._deDongTab(DongTab), frm = this, TopLevel = false, Dock = DockStyle.Fill, Text = tieuDe };
                        break;

                }
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;
            }
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            if (ClsMain.giaoVien.MaNhom.Equals("1"))
            {
                OpenForm(new FrmQuanLyTaiKhoan_Main(), "Quản lý tài khoản", true);
            }
            else
            {
                MessageBox.Show(String.Format("Tài khoản {0} {1} không có quyền trên chức năng này", ClsMain.giaoVien.HoGiaoVien, ClsMain.giaoVien.TenGiaoVien), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmThayDoiMatKhau_Main frmThayDoiMatKhau_Main = new FrmThayDoiMatKhau_Main();
            frmThayDoiMatKhau_Main.ShowDialog();
        }

        private void btn__DanhMucKhoa_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_DanhMucKhoa_Main(), "Quản lý danh mục khoa", true);
        }

        private void btn__ChucVuTrongLop_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_ChucVu_Main(), "Quản lý chức vụ trong lớp", true);
        }

        private void btn__DanhMucLop_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_DanhMucLop_Main(), "Quản lý Danh  mục lớp", true);
        }

        private void btn__QuanHeGiaDinh_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_QuanHeGiaDinh_Main(), "Quản lý Quan hệ gia đình", true);
        }

        private void btn__LoaiXuLyHocVu_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_LoaiXuLyHocVu_Main(), "Quản lý Loại xử lý học vụ", true);
        }

        private void btn__NhomTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_NhomTaiKhoan_Main(), "Quản lý Nhóm tài khoản", true);
        }

        private void Frm__HoSoHocSinh_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_HoSoHocSinh_Main(), "Hồ sơ sinh viên", true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_QuanLyGiaoVienChuNhiem_Main(), "Quản lý giáo viên chủ nhiệm", true);
        }

        private void btnXuLyHocVu_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_XuLyHocVu_Main(), "Xử lý học vụ", true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_QuanLyHocTap_Main(), "Quản lý học tập", true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_QuanLyNoiNgoaiTru_Main(), "Quản lý Nội - Ngoại trú", true);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            ClsMain.giaoVien = null;
            lblUserName.Text = "";
            frmLogin.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            if (ClsMain.giaoVien.MaNhom.Equals("1"))
            {
                OpenForm(new Frm_BackUp__Restore(), "Sao lưu và phục hồi dữ liệu", true);
            }
            else
            {
                MessageBox.Show(String.Format("Tài khoản {0} {1} không có quyền trên chức năng này", ClsMain.giaoVien.HoGiaoVien, ClsMain.giaoVien.TenGiaoVien), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            if (ClsMain.giaoVien.MaNhom.Equals("1"))
            {
                OpenForm(new Frm_PhanQuyen_Main(), "Quản lý phân quyền", true);
            }
            else
            {
                MessageBox.Show(String.Format("Tài khoản {0} {1} không có quyền trên chức năng này", ClsMain.giaoVien.HoGiaoVien, ClsMain.giaoVien.TenGiaoVien), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

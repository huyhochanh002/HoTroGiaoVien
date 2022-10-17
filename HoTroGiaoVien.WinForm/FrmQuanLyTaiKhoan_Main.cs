using HoTroGiaoVien.BussinessLayer;
using HoTroGiaoVien.DAO.EF;
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
    public partial class FrmQuanLyTaiKhoan_Main : Form
    {
        public FrmQuanLyTaiKhoan_Main()
        {
            InitializeComponent();
        }
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;

        BLL_TaiKhoan db;
        DataTable dtTaiKhoan;
        string err = string.Empty;
        private void FrmQuanLyTaiKhoan_Main_Load(object sender, EventArgs e)
        {
            db = new BLL_TaiKhoan(ClsMain.arrayPath, ClsMain.fileType);
            DisplayTaiKhoanList();
        }

        private void DisplayTaiKhoanList()
        {
            dtTaiKhoan = new DataTable();
            dtTaiKhoan = db.GetTaiKhoanList(ref err);
            if (dtTaiKhoan != null)
            {
                dgvTaiKhoanList.DataSource = dtTaiKhoan.DefaultView;
                lblTongSoTaiKhoan.Text = string.Format("Tổng số tài khoản: {0}", dtTaiKhoan.Rows.Count);
            }
            else
            {
                lblTongSoTaiKhoan.Text = string.Format("Tổng số tài khoản: {0}",0);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DongTab();
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            DisplayTaiKhoanList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_QuanLyTaiKhoan_Modified frm_QuanLyTaiKhoan_Modified = new Frm_QuanLyTaiKhoan_Modified();
            frm_QuanLyTaiKhoan_Modified.isAdd = true;
            frm_QuanLyTaiKhoan_Modified.ShowDialog();
        }
        TaiKhoan taiKhoan;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (taiKhoan != null)
            {
                Frm_QuanLyTaiKhoan_Modified frm_QuanLyTaiKhoan_Modified = new Frm_QuanLyTaiKhoan_Modified();
                frm_QuanLyTaiKhoan_Modified.isAdd = false;
                frm_QuanLyTaiKhoan_Modified.taiKhoan=taiKhoan;
                frm_QuanLyTaiKhoan_Modified.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (taiKhoan != null)
            {
                //Thuc hien xoa tai khoan
            }
            else
            {
                MessageBox.Show("Chưa chọn tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

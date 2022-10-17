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

namespace HoTroGiaoVien.WinForm.DanhMuc
{
    public partial class Frm_DanhMucLop_Main : Form
    {
        public Frm_DanhMucLop_Main()
        {
            InitializeComponent();
        }
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;

        BLL_DanhMucLop db;
        DataTable dtDanhMucLop;

        string err = string.Empty;
        private void Frm_DanhMucLop_Main_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            db = new BLL_DanhMucLop(ClsMain.arrayPath, ClsMain.fileType);
            HienThiDanhSachLop();
        }

        private void HienThiDanhSachLop()
        {
            try
            {
                dtDanhMucLop = new DataTable();
                dtDanhMucLop = db.GetDanhMucLop(ref err);
                dgvDanhMucLop.DataSource = dtDanhMucLop.DefaultView;
                lblErr.Text = string.Format("Số lượng lớp: {0}", dtDanhMucLop.Rows.Count);
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

        }

        private void btn__Them_Click(object sender, EventArgs e)
        {

        }
    }
}

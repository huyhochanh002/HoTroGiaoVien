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
    public partial class Frm_DanhMucKhoa_Main : Form
    {
        public Frm_DanhMucKhoa_Main()
        {
            InitializeComponent();
        }
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        private void Frm_DanhMucKhoa_Main_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DongTab();
        }

        private void btn__Thoat_Click(object sender, EventArgs e)
        {
            DongTab();
        }
    }
}

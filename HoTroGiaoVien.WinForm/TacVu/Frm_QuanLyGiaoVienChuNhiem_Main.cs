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
    public partial class Frm_QuanLyGiaoVienChuNhiem_Main : Form
    {
        public Frm_QuanLyGiaoVienChuNhiem_Main()
        {
            InitializeComponent();
        }
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DongTab();
        }

     
    }
}

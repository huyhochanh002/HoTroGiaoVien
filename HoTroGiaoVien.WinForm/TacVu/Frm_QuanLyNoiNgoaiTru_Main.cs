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
    public partial class Frm_QuanLyNoiNgoaiTru_Main : Form
    {
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        public Frm_QuanLyNoiNgoaiTru_Main()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DongTab();
        }
    }
}

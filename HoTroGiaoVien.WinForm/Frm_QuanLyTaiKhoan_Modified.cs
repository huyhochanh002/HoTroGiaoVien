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
    public partial class Frm_QuanLyTaiKhoan_Modified : Form
    {
        public Frm_QuanLyTaiKhoan_Modified()
        {
            InitializeComponent();
        }

        public bool isAdd = false;
        public TaiKhoan taiKhoan = new TaiKhoan();

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}

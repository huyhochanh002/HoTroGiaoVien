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
    public partial class Frm_HoSoHocSinh_Modified : Form
    {
        public Frm_HoSoHocSinh_Modified()
        {
            InitializeComponent();
        }
        public bool isAdd = false;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_HoSoHocSinh_Modified_Load(object sender, EventArgs e)
        {
           
            lblisAdd.Text = isAdd.ToString();
            if(!isAdd)
            {
                tabThemBangDanhFile.Visible = false;
            }
        }
    }
}

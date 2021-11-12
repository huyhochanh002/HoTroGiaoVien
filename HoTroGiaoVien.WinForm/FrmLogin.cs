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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.label1.BackColor = ClsMain.backgroud_color;
            this.label2.BackColor = ClsMain.backgroud_color;
            this.label3.BackColor = ClsMain.backgroud_color;
            this.label4.BackColor = ClsMain.backgroud_color;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

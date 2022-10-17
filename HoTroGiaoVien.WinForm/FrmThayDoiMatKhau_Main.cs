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

namespace HoTroGiaoVien.WinForm
{
    public partial class FrmThayDoiMatKhau_Main : Form
    {
        public FrmThayDoiMatKhau_Main()
        {
            InitializeComponent();
        }
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        string err = string.Empty;

        BLL_HeThong db;
        private void FrmThayDoiMatKhau_Main_Load(object sender, EventArgs e)
        {
            db = new BLL_HeThong(ClsMain.arrayPath, ClsMain.fileType);
            if (ClsMain.giaoVien.MaNhom.Equals("1"))
            {
                LoadcboTaiKhoan();
                gbResetPassword.Enabled = true;
            }
            else
            {
                gbResetPassword.Enabled = false;
            }

        }

        private void LoadcboTaiKhoan()
        {
            DataTable dt = new DataTable();
            dt = db.GetTaiKhoanList(ref err);

            cboTaiKhoan.DataSource = dt;

            cboTaiKhoan.ValueMember = "";
            cboTaiKhoan.DisplayMember = "";

            cboTaiKhoan.SelectedIndex = -1;
            cboTaiKhoan.Text = "---Chọn tài khoản ---";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassWordNew.Text))
            {
                if (!string.IsNullOrEmpty(txtPrePasswordNew.Text))
                {
                    if (db.ChangedPassword(ref err, ClsMain.giaoVien.MaGiaoVien, txtPassWordNew.Text))
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi mật khẩu không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtPrePasswordNew_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassWordNew.Text))
            {
                if (txtPrePasswordNew.Text != txtPassWordNew.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrePasswordNew.ResetText();
                    txtPrePasswordNew.Focus();
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (cboTaiKhoan.SelectedIndex >= 0)
            {
                if (db.ResetPassword(ref err, cboTaiKhoan.SelectedValue.ToString()))
                {
                    MessageBox.Show("Cấp lại mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cấp lại mật khẩu không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

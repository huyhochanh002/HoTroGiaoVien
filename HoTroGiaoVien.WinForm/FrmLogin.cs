using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoTroGiaoVien.BussinessLayer;
using HoTroGiaoVien.DAO.EF;

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

        BLL_HeThong db;
        string err = string.Empty;
        DataTable dtThongTinLogin;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            db = new BLL_HeThong(ClsMain.arrayPath, ClsMain.fileType);

            txtPassword.Text = "admin";
            txtUserName.Text = "NV0000001";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (CheckLogin(txtUserName.Text, txtPassword.Text))
            {
                this.Close();
            }

        }

        private bool CheckLogin(string userName, string passWord)
        {
            dtThongTinLogin = new DataTable();
            dtThongTinLogin = db.CheckLogin(ref err, userName, passWord);
            if (dtThongTinLogin.Rows.Count > 0)
            {
                if (dtThongTinLogin.Rows[0]["result"].ToString().Equals("1"))
                {
                    if (dtThongTinLogin.Rows[0]["MaNhom"].ToString().Equals("2") || dtThongTinLogin.Rows[0]["MaNhom"].ToString().Equals("3") || dtThongTinLogin.Rows[0]["MaNhom"].ToString().Equals("1"))
                    {
                        ClsMain.giaoVien = new GiaoVien()
                        {
                            MaGiaoVien = dtThongTinLogin.Rows[0]["MaGiaoVien"].ToString(),
                            HoGiaoVien = dtThongTinLogin.Rows[0]["HoGiaoVien"].ToString(),
                            TenGiaoVien = dtThongTinLogin.Rows[0]["TenGiaoVien"].ToString(),
                            DienThoai = dtThongTinLogin.Rows[0]["DienThoai"].ToString(),
                            Email = dtThongTinLogin.Rows[0]["Email"].ToString(),
                            Facebook = dtThongTinLogin.Rows[0]["Facebook"].ToString(),
                            Zalo = dtThongTinLogin.Rows[0]["Zalo"].ToString(),
                            DiaChi = dtThongTinLogin.Rows[0]["DiaChi"].ToString(),
                            MaKhoa = dtThongTinLogin.Rows[0]["MaKhoa"].ToString(),
                            MaNguoiDung = dtThongTinLogin.Rows[0]["MaNguoiDung"].ToString(),
                            MaNhom = dtThongTinLogin.Rows[0]["MaNhom"].ToString()
                        };
                    }

                    return true;
                }
                else
                {
                    return false;
                }

            }
            else { return false; }
        }
    }
}

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

namespace HoTroGiaoVien.WinForm.TacVu
{
    public partial class Frm_QuanLyGiaoVienChuNhiem_Modified : Form
    {
        public Frm_QuanLyGiaoVienChuNhiem_Modified()
        {
            InitializeComponent();
        }

        public bool isAdd = false;
        string err = string.Empty;
        BLL_GiaoVien db;
        public GiaoVien giaoVien = null;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_QuanLyGiaoVienChuNhiem_Modified_Load(object sender, EventArgs e)
        {
            db = new BLL_GiaoVien(ClsMain.arrayPath, ClsMain.fileType);
            LoadCboKhoa();
            if (isAdd)
            {
                txtMaGiaoVien.Focus();
            }
            else
            {
                HienThiThongTinToControl(giaoVien);
            }
        }

        private void LoadCboKhoa()
        {
            DataTable dt = new DataTable();
            dt = db.GetKhoaToCbo(ref err);

            cboKhoa.DataSource = dt;

            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.DisplayMember = "TenKhoa";

            cboKhoa.SelectedIndex = -1;
            cboKhoa.Text = "---Chọn Khoa---";
        }

        private void HienThiThongTinToControl(GiaoVien giaoVien)
        {
            if (giaoVien != null)
            {
                txtMaGiaoVien.Text = giaoVien.MaGiaoVien.ToString();
                txtMaGiaoVien.Enabled = false;
                txtHoGiaoVien.Text = giaoVien.HoGiaoVien.ToString();
                txtTenGiaoVien.Text = giaoVien.TenGiaoVien.ToString();
                txtDienThoai.Text = giaoVien.DienThoai.ToString(); ;
                txtEmail.Text = giaoVien.Email.ToString();
                txtFacebook.Text = giaoVien.Facebook.ToString();
                txtZalo.Text = giaoVien.Zalo.ToString();
                txtDiaChi.Text = giaoVien.DiaChi.ToString();
                cboKhoa.SelectedValue = giaoVien.MaKhoa.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            GetDataFromControl();
            if (db.InsertAndUpdateGiaoVien(ref err, giaoVien))
            {
                MessageBox.Show("Thêm giáo viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetConrol();
            }
            else
            {
                MessageBox.Show("Thêm giáo viên không thành công \n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetConrol()
        {
            txtMaGiaoVien.ResetText();
            txtHoGiaoVien.ResetText();
            txtTenGiaoVien.ResetText();
            txtDienThoai.ResetText();
            txtEmail.ResetText();
            txtFacebook.ResetText();
            txtZalo.ResetText();
            txtDiaChi.ResetText();
            cboKhoa.SelectedIndex = -1;
            cboKhoa.Text = "---Chọn Khoa---";
            txtMaGiaoVien.Focus();
        }

        private void GetDataFromControl()
        {
            giaoVien = new GiaoVien()
            {
                MaGiaoVien = txtMaGiaoVien.Text,
                HoGiaoVien = txtHoGiaoVien.Text,
                TenGiaoVien = txtTenGiaoVien.Text,
                DienThoai = txtDienThoai.Text.ToString(),
                Email = txtEmail.Text.ToString(),
                Facebook = txtFacebook.Text.ToString(),
                Zalo = txtZalo.Text.ToString(),
                DiaChi = txtDiaChi.Text.ToString(),
                MaKhoa = cboKhoa.SelectedValue.ToString()
            };
        }
    }
}

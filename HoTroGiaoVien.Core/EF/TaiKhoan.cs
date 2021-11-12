using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroGiaoVien.DAO.EF
{
   public class TaiKhoan
    {
        string maNguoiDung, tenDangNhap, matKhau, maNhom;
        bool isDelete;

        public string MaNguoiDung { get => maNguoiDung; set => maNguoiDung = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaNhom { get => maNhom; set => maNhom = value; }
        public bool IsDelete { get => isDelete; set => isDelete = value; }
    }
}

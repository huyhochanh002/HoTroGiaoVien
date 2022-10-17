using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroGiaoVien.DAO.EF
{
    public class GiaoVien
    {
        string maGiaoVien, hoGiaoVien, tenGiaoVien, dienThoai, email, facebook, zalo, diaChi, maKhoa, maNguoiDung, maNhom;

        public string MaGiaoVien { get => maGiaoVien; set => maGiaoVien = value; }
        public string HoGiaoVien { get => hoGiaoVien; set => hoGiaoVien = value; }
        public string TenGiaoVien { get => tenGiaoVien; set => tenGiaoVien = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string Facebook { get => facebook; set => facebook = value; }
        public string Zalo { get => zalo; set => zalo = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaNguoiDung { get => maNguoiDung; set => maNguoiDung = value; }
        public string MaNhom { get => maNhom; set => maNhom = value; }
    }
}

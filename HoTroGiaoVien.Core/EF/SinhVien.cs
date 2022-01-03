using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroGiaoVien.DAO.EF
{
   public class SinhVien
    {
        string maSinhVien, hoSinhVien, tenSinhVien,  diaChi, tinh, quanHuyen, phuongXa, dienThoai, email, facebook, hinhDaiDien, maLop,  maChucVu,  danToc, tonGiao, queQuan, quocTich, noiSinh, maNguoiDung;
        DateTime ngaySinh;
        bool tinhTrang,gioiTinh;
        double  dTBHocTap;

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string HoSinhVien { get => hoSinhVien; set => hoSinhVien = value; }
        public string TenSinhVien { get => tenSinhVien; set => tenSinhVien = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Tinh { get => tinh; set => tinh = value; }
        public string QuanHuyen { get => quanHuyen; set => quanHuyen = value; }
        public string PhuongXa { get => phuongXa; set => phuongXa = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string Facebook { get => facebook; set => facebook = value; }
        public string HinhDaiDien { get => hinhDaiDien; set => hinhDaiDien = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string NoiSinh { get => noiSinh; set => noiSinh = value; }
        public string MaNguoiDung { get => maNguoiDung; set => maNguoiDung = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public double DTBHocTap { get => dTBHocTap; set => dTBHocTap = value; }
    }
}

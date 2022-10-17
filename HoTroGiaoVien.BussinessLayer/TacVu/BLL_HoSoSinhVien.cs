using HoTroGiaoVien.Commons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroGiaoVien.BussinessLayer.TacVu
{
    public class BLL_HoSoSinhVien : BLL_Base
    {
        public BLL_HoSoSinhVien(string[] path, FileConnectType fileType)
            : base(path, fileType)
        {

        }
        #region Method
        /// <summary>
        /// Lấy danh sách lớp vào trong cbo theo mã số giáo viên
        /// </summary>
        /// <param name="err"></param>
        /// <param name="maGiaoVien">Mã giáo viên</param>
        /// <returns></returns>
        public DataTable LayDuLieuChoComboLop(ref string err, string maGiaoVien)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaGiaoVien",maGiaoVien)
            };
            return data.MyGetDataTable(ref err, "PSP_Lop_LayDanhSachChoCombo", CommandType.StoredProcedure, param);
        }

        public DataTable LayDanhSachSinhVienTheoGiaoVien(ref string err, string maGiaoVien)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaGiaoVien",maGiaoVien)
            };
            return data.MyGetDataTable(ref err, "PSP_SinhVien_LayDanhSachTheo__GiaoVienChuNhiem", CommandType.StoredProcedure, param);
        }

        public DataTable GetChiTietXyLyHocVuByGiaoVien(ref string err, string maGiaoVien)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaGiaoVien",maGiaoVien)
            };
            return data.MyGetDataTable(ref err, "PSP_XuLyHocVu_TheoGiaoVien", CommandType.StoredProcedure, param);
        }

        public DataTable GetDataCboLop(ref string err, string maGiaoVien)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaGiaoVien",maGiaoVien)
            };
            return data.MyGetDataTable(ref err, "PSP_Lop_SelectCbo", CommandType.StoredProcedure, param);
        }
        #endregion

        #region Các phương thức cho form Profile sinh viên
        //Lấy thông tin cá nhân
        public DataTable LayThongTinCaNhanSinhVien(ref string err, string maSinhVien)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaSinhVien",maSinhVien)
            };
            return data.MyGetDataTable(ref err, "PSP_SinhVien_LayThongTinCaNhanByID", CommandType.StoredProcedure, param);
        }

        public DataTable LayThongTinGiaDinhTheoMaSinhVien(ref string err, string maSinhVien)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaSinhVien",maSinhVien)
            };
            return data.MyGetDataTable(ref err, "PSP_SinhVien_LayThongTinGiaDinh", CommandType.StoredProcedure, param);
        }

        public DataTable GetChiTietGhiChu(ref string err,string maSinhVien)
        {

            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaSinhVien",maSinhVien)
            };
            return data.MyGetDataTable(ref err, "PSP_GhiChu_SelectByMaSinhVien", CommandType.StoredProcedure, param);
        }

        public bool InsertAndUpdateGhiChu(ref string err, string maSinhVien, string maGhiChu, string noiDung, DateTime ngayTao, string maNhanVien)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaSinhVien",maSinhVien),
                 new SqlParameter("@MaGhiChu",maGhiChu),
                  new SqlParameter("@NoiDung",noiDung),
                   new SqlParameter("@NgayTao",ngayTao),
                    new SqlParameter("@MaGiaoVien",maNhanVien),
            };
            return data.MyExecuteNonQuery(ref err, "PSP_GhiChu_InsertAndUpdate", CommandType.StoredProcedure, param);
        }

        public DataTable GetHocKy(ref string err)
        {
            return data.MyGetDataTable(ref err, "PSP_HocKy_Select_Combo", CommandType.StoredProcedure, null);
        }

        public DataTable GetLoaiXuLy(ref string err)
        {
            return data.MyGetDataTable(ref err, "PSP_LoaiXuLyHocVu_Select_Combo", CommandType.StoredProcedure, null);
        }

        public bool InsertAndUpdateXuLyHocVu(ref string err, string maSinhVien, string maHocKy, DateTime ngayLamViec, string loaiXuLyHocVu, string noiDungLamViec, string ketLuan)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaSinhVien",maSinhVien),
                new SqlParameter("@MaHocKy",maHocKy),
                 new SqlParameter("@NgayLamViec",ngayLamViec),
                  new SqlParameter("@MaLoaiXuLy",loaiXuLyHocVu),
                   new SqlParameter("@NoiDungLamViec",noiDungLamViec),
                    new SqlParameter("@KetLuan",ketLuan)
            };
            return data.MyExecuteNonQuery(ref err, "PSP_LoaiXuLyHocVu_InsertAndUpdate", CommandType.StoredProcedure, param);
        }

        public DataTable GetChiTietXuLyHocVu(ref string err, string maSinhVien)
        {

            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaSinhVien",maSinhVien)
            };
            return data.MyGetDataTable(ref err, "PSP_XuLyHocVu_Select", CommandType.StoredProcedure, param);
        }

        public bool UpdateTinhTrangSinhVien(ref string err, string maSinhVien, int tinhTrang)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaSinhVien",maSinhVien),
                new SqlParameter("@TinhTrang",tinhTrang)
            };
            return data.MyExecuteNonQuery(ref err, "PSP_SinhVien_UpdateTrangTrai", CommandType.StoredProcedure, param);
        }

        public DataTable GetChiTietSoThich(ref string err, string maSinhVien)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaSinhVien",maSinhVien)
            };
            return data.MyGetDataTable(ref err, "PSP_SoThich_Select", CommandType.StoredProcedure, param);
        }

        public bool InsertAndUpdateSoThich(ref string err, string maSinhVien, string soLuong, string soThich)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaSinhVien",maSinhVien),
                new SqlParameter("@SoLuong",soLuong),
                 new SqlParameter("@NoiDung",soThich)
            };
            return data.MyExecuteNonQuery(ref err, "PSP_SoThich_InsertAndUpdate", CommandType.StoredProcedure, param);
        }

        public DataTable GetChiTietNoiNgoaiTru(ref string err, string maSinhVien)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaSinhVien",maSinhVien)
            };
            return data.MyGetDataTable(ref err, "PSP_NgoaiTru_Select", CommandType.StoredProcedure, param);
        } 
        public DataTable GetComboTinh(ref string err)
        {
            return data.MyGetDataTable(ref err, "PSP_Tinh_SelectCombo", CommandType.StoredProcedure, null);
        }

        public DataTable GetComboHuyen(ref string err, string maTinh)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaTinh",maTinh)
            };

            return data.MyGetDataTable(ref err, "PSP_QuanHuyen_SelectCombo", CommandType.StoredProcedure, param);
        }

        public DataTable GetComboPhuong(ref string err, string maHuyen)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaQuanHuyen",maHuyen)
            };

            return data.MyGetDataTable(ref err, "PSP_PhuongXa_SelectCombo", CommandType.StoredProcedure, param);
        }

        public bool InsertAndUpDateNgoaiTru(ref string err, string maSinhVien, string maNgoaiTru,string phanLoai, string noiCuTru, string diaChiCuTru, string maTinh, string maHuyen, string maPhuong)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaSinhVien",maSinhVien),
                new SqlParameter("@MaNgoaiTru",maNgoaiTru),
                     new SqlParameter("@PhanLoai",phanLoai),
                 new SqlParameter("@NoiCuTru",noiCuTru),
                 new SqlParameter("@DiaChiCuTru",diaChiCuTru),
                new SqlParameter("@Tinh",maTinh),
                 new SqlParameter("@QuanHuyen",maHuyen),
                   new SqlParameter("@PhuongXa",maPhuong)
            };
            return data.MyExecuteNonQuery(ref err, "PSP_NgoaiTru_InsertAndUpdate", CommandType.StoredProcedure, param);
        }

        #endregion
    }
}

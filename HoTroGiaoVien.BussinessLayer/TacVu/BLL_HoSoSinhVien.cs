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
        #endregion
    }
}


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
    public class BLL__HomePage : BLL_Base
    {
        public BLL__HomePage(string[] path, FileConnectType fileType)
            : base(path, fileType)
        {

        }
        #region Method
        /// <summary>
        /// Phương thức lấy số lượng sinh viên theo từng năm: sl, nam, nữ, dang học,bảo lưu, nghỉ luôn.
        /// </summary>
        /// <param name="err">Biến tham chiếu cho phương thức lưu lỗi</
        /// <returns>Danh sách thong kê theo năm</returns>
        public DataTable LaySoLuongThuongKe(ref string err, string maGiaoVien)
        {
            SqlParameter[] param = new SqlParameter[]
           {
                new SqlParameter("@MaGiaoVien",maGiaoVien)
           };
            return data.MyGetDataTable(ref err, "PSP_ThongKe_LaySoLuongTheoTungNam", CommandType.StoredProcedure, param);
        }

        public DataTable LayDanhSachSinhVien(ref string err, bool isCanBo, string maGiaoVien)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@IsCanBo",isCanBo),
                new SqlParameter("@MaGiaoVien",maGiaoVien)
            };
            return data.MyGetDataTable(ref err, "PSP_ThongKe_DanhSachCanBoLop", CommandType.StoredProcedure, param);
        }
        public DataTable LayDuLieuChoComboLop(ref string err, string maGiaoVien)
        {
            SqlParameter[] param = new SqlParameter[]
           {
                new SqlParameter("@MaGiaoVien",maGiaoVien)
           };
            return data.MyGetDataTable(ref err, "PSP_Lop_LayDanhSachChoCombo", CommandType.StoredProcedure, param);
        }
        public DataTable LayDuLieuChoComboGiaoVien(ref string err)
        {
            return data.MyGetDataTable(ref err, "PSP_GiaoVien_HienThiDanhSachGiaoVienCbo", CommandType.StoredProcedure, null);
        }

        public DataTable LayDanhSachLop(ref string err)
        {
            return data.MyGetDataTable(ref err, "PSP_Lop_LayDanhSachLop", CommandType.StoredProcedure, null);
        }


        #endregion

    }
}

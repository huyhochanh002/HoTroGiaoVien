using HoTroGiaoVien.Commons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoTroGiaoVien.DAO.EF;

namespace HoTroGiaoVien.BussinessLayer
{
    public class BLL_GiaoVien : BLL_Base
    {
        public BLL_GiaoVien(string[] path, FileConnectType fileType)
          : base(path, fileType)
        {

        }
        public DataTable GetGiaoVienList(ref string err)
        {
            return data.MyGetDataTable(ref err, "PSP_GiaoVien_Select", CommandType.StoredProcedure, null);
        }
        public DataTable GetGiaoVienToCombo(ref string err)
        {
            return data.MyGetDataTable(ref err, "PSP_GiaoVien_HienThiDanhSachGiaoVienCbo", CommandType.StoredProcedure, null);

        }

        public DataTable GetDanhSachLop(ref string err)
        {
            return data.MyGetDataTable(ref err, "PSP_Lop_HienThiPhanLop", CommandType.StoredProcedure, null);
        }
        public DataTable GetKhoaToCbo(ref string err)
        {
            return data.MyGetDataTable(ref err, "PSP_Khoa_SelectCbo", CommandType.StoredProcedure, null);
        }


        public bool SavePhanCongGiaoVien(ref string err, string maLop, string maGiaoVien)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
               new SqlParameter("@MaLop",maLop),
               new SqlParameter("@MaGiaoVien",maGiaoVien)
            };
            return data.MyExecuteNonQuery(ref err, "PSP_Lop_PhanCongGiaoVienChuNhiem", CommandType.StoredProcedure, sqlParameters);
        }

        public bool InsertAndUpdateGiaoVien(ref string err, GiaoVien giaoVien)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
               new SqlParameter("@MaGiaoVien",giaoVien.MaGiaoVien),
               new SqlParameter("@HoGiaoVien",giaoVien.HoGiaoVien),
                new SqlParameter("@TenGiaoVien",giaoVien.TenGiaoVien),
                 new SqlParameter("@DienThoai",giaoVien.DienThoai),
                  new SqlParameter("@Email",giaoVien.Email),
                   new SqlParameter("@Facebook",giaoVien.Facebook),
                    new SqlParameter("@Zalo",giaoVien.Zalo),
                     new SqlParameter("@MaKhoa",giaoVien.MaKhoa),
                      new SqlParameter("@DiaChi",giaoVien.DiaChi)
            };
            return data.MyExecuteNonQuery(ref err, "PSP_GiaoVien_InsertAndUpdate", CommandType.StoredProcedure, sqlParameters);
        }


        public bool DeleteGiaoVien(ref string err, string maGiaoVien)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
               new SqlParameter("@MaGiaoVien",maGiaoVien)
            };
            return data.MyExecuteNonQuery(ref err, "PSP_GiaoVien_Delete", CommandType.StoredProcedure, sqlParameters);
        }
    }
}

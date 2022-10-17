using HoTroGiaoVien.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HoTroGiaoVien.BussinessLayer
{
    public class BLL_HeThong : BLL_Base
    {
        public BLL_HeThong(string[] path, FileConnectType fileType)
            : base(path, fileType)
        {

        }

        public DataTable CheckLogin(ref string err, string userName, string passWord)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@UserName",userName),
                new SqlParameter("@Password",passWord)
            };
            return data.MyGetDataTable(ref err, "PSP_WF_CheckLogin", CommandType.StoredProcedure, sqlParameters);
        }

        public bool ChangedPassword(ref string err, string userName, string passWord)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@UserName",userName),
                new SqlParameter("@Password",passWord)
            };
            return data.MyExecuteNonQuery(ref err, "PSP_TaiKhoan_ChangedPassword", CommandType.StoredProcedure, sqlParameters);
        }

        public DataTable GetTaiKhoanList(ref string err)
        {
            return data.MyGetDataTable(ref err, "PSP_TaiKhoan_LoadCbo", CommandType.StoredProcedure, null);
        }


        public bool ResetPassword(ref string err, string maTaiKhoan)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@MaNguoiDung",maTaiKhoan)

            };
            return data.MyExecuteNonQuery(ref err, "PSP_TaiKhoan_ResetPassword", CommandType.StoredProcedure, sqlParameters);
        }

        public bool Backup(ref string err, string path)
        {
            return data.MyExecuteNonQuery(ref err, "PSP_Backup", CommandType.StoredProcedure, new SqlParameter("@duongdan", path));
        }

        public bool Restore(ref string err, string sql)
        {
            return data.MyExecuteNonQuery(ref err, sql, CommandType.Text, null);
        }
    }
}

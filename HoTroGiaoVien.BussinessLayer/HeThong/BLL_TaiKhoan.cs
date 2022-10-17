using HoTroGiaoVien.Commons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroGiaoVien.BussinessLayer
{
    public class BLL_TaiKhoan : BLL_Base
    {
        public BLL_TaiKhoan(string[] path, FileConnectType fileType)
           : base(path, fileType)
        {

        }

        public DataTable GetTaiKhoanList(ref string err)
        {
            return data.MyGetDataTable(ref err, "PSP_TaiKhoan_Select", CommandType.StoredProcedure, null);
        }
    }
}

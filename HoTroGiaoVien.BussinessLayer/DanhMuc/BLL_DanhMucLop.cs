using HoTroGiaoVien.Commons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroGiaoVien.BussinessLayer
{
    public class BLL_DanhMucLop : BLL_Base
    {

        public BLL_DanhMucLop(string[] path, FileConnectType fileType)
           : base(path, fileType)
        {

        }

        public DataTable GetDanhMucLop(ref string err)
        {
            throw new NotImplementedException();
        }
    }
}

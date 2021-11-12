using HoTroGiaoVien.Commons;
using HoTroGiaoVien.DataLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroGiaoVien.BussinessLayer
{
   public class BLL_Base : IDisposable
    {
        public Database data;
        public void Dispose()
        {
            if (data != null)
            {
                data.Dispose();
                data = null;
            }
        }
        public BLL_Base(string[] path, FileConnectType filetype)
        {
            data = new Database(path, filetype);
        }
    }
}

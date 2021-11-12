using HoTroGiaoVien.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroGiaoVien.DataLayer.ConnectionManager
{
   public interface IReadConnectFactory
    {
       void CreateReadConnectionString(FileConnectType fileType);
    }
}

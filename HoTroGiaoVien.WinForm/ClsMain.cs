using HoTroGiaoVien.Commons;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroGiaoVien.WinForm
{
    public class ClsMain
    {
        #region skin
        public static Color backgroud_color = Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(56)))), ((int)(((byte)(221)))));//21, 101, 192
        public static Color backgroud_color2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
        #endregion
        //Mảng chửa đường dẫn file kết nối
        public static string[] arrayPath = new string[] {
            Application.StartupPath+@"\Connect.ini",
            Application.StartupPath + @"\App.config",
            ""};
        //Mặc định connectionString được lưu vào trong file ini
        public static FileConnectType fileType = FileConnectType.INI;
        //Chứa danh sách giá trị quyền của các user trong chương trình.
        public static Hashtable BangPhanQuyen = new Hashtable();

        public static SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        public static void GetPermissionByUser(ref string err, ref int rows, string maNhanVien)
        {
            try
            {
                DataTable dt = new DataTable();
                //dt = bd.LayBangPhanQuyen(ref err, ref rows, maNhanVien);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        if (!ClsMain.BangPhanQuyen.ContainsKey(item["KyHieu"].ToString()))
                        {
                            ClsMain.BangPhanQuyen.Add(item["KyHieu"].ToString(), Convert.ToInt32(item["GiaTriQuyen"].ToString()));
                        }
                        else
                        {
                            ClsMain.BangPhanQuyen[item["KyHieu"].ToString()] = Convert.ToInt32(item["GiaTriQuyen"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                err = ex.Message;
            }

        }
        public static bool KiemTraQuyen(int tongQuyen, int value)
        {
            return (tongQuyen & value) == value;
        }
        public static string tenNhanVien = string.Empty;
        public static string maTaiKhoan = string.Empty;
        public static string maNhanVien = string.Empty;
        public static string TenDangNhap = string.Empty;

        public static string hinhDaiDienNull = string.Format(@"{0}\img_avatar2.png", Application.StartupPath);


    }
}

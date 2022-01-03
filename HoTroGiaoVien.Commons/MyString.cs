using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HoTroGiaoVien.Commons
{
    public class MyString
    {

        /// <summary>
        /// Kiểm tra một chuỗi có phải là số hay không
        /// </summary>
        /// <param name="pValue">Chuỗi ký tự cần kiểm tra</param>
        /// <returns>Nếu là số trả về True, ngược lại trả về False</returns>
        public static bool IsNumber(string pText)
        {

            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);

        }
        /// <summary>
        /// Mảng sử dụng để bỏ dấu tiếng việt
        /// </summary>
        private static readonly string[] VietnameseSigns = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởõ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞÕ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỷỹỵ",
            "ÝỲỶỸỴ"
        };
        /// <summary>
        /// Phương thức sử dụng để bỏ dấu tiếng việt.
        /// chuyển một câu có dấu thành một câu không dấu tương ứng.
        /// </summary>
        /// <param name="str">Chuỗi có dấu được truyền vào phương thức</param>
        /// <returns>Chuỗi không dấu tương ứng</returns>
        public static string RemoveVietnameseAccents(string str)
        {
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                {
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
                }
            }
            return str;
        }
        /// <summary>
        /// Xóa khoảng trắng dư trong chuỗi truyền vào
        /// </summary>
        /// <param name="chuoi">Chuỗi truyền vào phương thức</param>
        /// <returns>Chuỗi đã được xóa khoảng trắng dư</returns>
        public static string RemoveWhitespace(string chuoi)
        {
            chuoi = chuoi.Trim();//xoa khoang trang dau va cuoi cua chuoi
            string mau = @"\s+";
            Regex myregex = new Regex(mau);
            return myregex.Replace(chuoi, " ");
        }

        /// <summary>
        /// Phương thức xóa các ký tự đặc biệt có trong chuỗi truyền vào
        /// </summary>
        /// <param name="chuoi">Chuỗi truyền vào phương thức</param>
        /// <returns>Chuỗi đã được xóa ký tự đặc biệt</returns>
        public static string RemoveSpecialCharacters(string chuoi)
        {
            chuoi = chuoi.Trim();//xoa khoang trang dau va cuoi cua chuoi
            string mau = @"\W+";
            Regex myregex = new Regex(mau);
            return myregex.Replace(chuoi, " ");
        }
        /// <summary>
        /// Phương thức lấy ký tự tắt từ chuỗi ký tự truyền vào
        /// Lấy ký tự đầu tiên trong chuỗi để ghép thành ký tự tắt
        /// </summary>
        /// <param name="chuoi">Chuỗi cần lấy ký tự tắt</param>
        /// <returns>Chuỗi viết tắt</returns>
        public static string GetAbbreviation(string chuoi)
        {
            chuoi = RemoveSpecialCharacters(chuoi.ToUpper());
            char[] charArr = chuoi.ToCharArray();
            string chuoitat = "";
            chuoitat = charArr[0].ToString();
            string mau = @"\s\S";
            Regex Myregex = new Regex(mau);
            MatchCollection mc;
            mc = Myregex.Matches(chuoi);
            foreach (Match item in mc)
            {
                chuoitat += item.Value.ToUpper().Trim()[0];
            }
            return chuoitat;
        }
        /// <summary>
        /// Phương thức sử dụng để tách tên ra khỏi chuỗi họ tên
        /// </summary>
        /// <param name="chuoi">Họ tên cần tách tên</param>
        /// <returns>Tên được tách</returns>
        public static string FirstNameSeparation(string chuoi)
        {
            int x = chuoi.LastIndexOf(" ");
            string ten = "";
            ten = chuoi.Substring(x);
            return ten.Trim();
        }
        /// <summary>
        /// Phương thức tách lấy họ trong chuỗi họ tên truyền vào
        /// </summary>
        /// <param name="chuoi">Chuỗi họ tên cần tách</param>
        /// <returns>Họ và tên lót được tách</returns>
        public static string LastNameSeparation(string chuoi)
        {
            int x = chuoi.LastIndexOf(" ");
            string ho = "";
            ho = chuoi.Substring(0, x);
            return ho.Trim();
        }
        /// <summary>
        /// Phương thức tách lấy tên file trong chuỗi đường dẫn truyền vào.
        /// </summary>
        /// <param name="chuoi">Đường dẫn tập tin</param>
        /// <returns>Tên tập tin</returns>
        public static string FileNameSeparstion(string chuoi)
        {
            int x = chuoi.LastIndexOf("\\");
            string tenfile = "";
            tenfile = chuoi.Substring(x);
            return tenfile.Trim();
        }
        /// <summary>
        /// Hàm chuyển các ký tự đầu các từ thành hoa
        /// </summary>
        /// <param name="str">tham số truyền vào</param>
        /// <returns>ví vụ: chuoi so --> Chuoi So</returns>

        public static string Proper(string str)
        {
            str = str.ToLower();
            char[] charArr = str.ToCharArray();
            charArr[0] = char.ToUpper(charArr[0]);
            foreach (Match m in Regex.Matches(str, @"\s\S"))
            {
                charArr[m.Index + 1] = m.Value.ToUpper().Trim()[0];
            }
            return new string(charArr);
        }

        public static bool CheckDate(ref string err, string _datetime)
        {
            bool ketqua = false;
            try
            {
                DateTime ngayhople = Convert.ToDateTime(_datetime);
                ketqua = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return ketqua;
        }
    }
}

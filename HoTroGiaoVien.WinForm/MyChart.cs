using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroGiaoVien.WinForm
{
   public class MyChart
    {
        int year;
        int quantity;
        int studentBreak;
        int male,female;


        public int Year { get => year; set => year = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int StudentBreak { get => studentBreak; set => studentBreak = value; }
        public int Male { get => male; set => male = value; }
        public int Female { get => female; set => female = value; }
    }
}

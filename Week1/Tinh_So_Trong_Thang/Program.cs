using System;
using System.Text;

namespace Tinh_So_Trong_Thang
{
    class Program
    {
        static void Main(string[] args)
        {

            int month;
            bool check;
            Console.OutputEncoding = Encoding.UTF8;
            System.Console.WriteLine("Nhap vao thang de kiem tra");
            check = int.TryParse(Console.ReadLine(), out month);
            while (month <= 0 || month > 12 || !check)
            {
                System.Console.WriteLine("Nhap Lại vào tháng để kiểm tra");
                check = int.TryParse(Console.ReadLine(), out month);
            }
            switch (month)
            {
                case 2:
                    System.Console.WriteLine("Thang" + " " + month + "co 28 29 ngay");
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    System.Console.WriteLine("thang" + " " + month + " co 31 ngay");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    System.Console.WriteLine("thang " + " " + month + " co 30 ngay");
                    break;



            }
        }
    }
}

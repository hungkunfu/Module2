using System;

namespace Chuyen_Doi_Tien_Te
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD;
            // double VN;
            bool check;
            System.Console.Write("Nhap vao Tien chuyen doi USD ");
            check = double.TryParse(Console.ReadLine(),out USD);
            while (!check || USD < 0)
            {
                System.Console.Write("Nhap vao Tien chuyen doi USD");
                check = double.TryParse(Console.ReadLine(),out USD);

            }
            double chuyendoi = USD * 23000;
            System.Console.WriteLine($"{USD} USD thanh VND = {chuyendoi} VND");
            Console.ReadKey();
            


        }
    }
}

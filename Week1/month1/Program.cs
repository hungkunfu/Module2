using System;

namespace test
{
    class Program
    {
        static double BinhPhuong(double number)
        {
            double ketqua = number * number;
            return ketqua;

        }
        static void Main(string[] args)
        {
            // Console.InputEncoding.UTF8;
            // Console.OutputEncoding = Encoding.UTF8;
            double tong = BinhPhuong(6);
            Console.WriteLine("======= chương trình thử nghiệm đầu tiên =======");
            Console.WriteLine($"tích là " + tong);
            Console.WriteLine("Bạn đã thành công");
            Console.ReadKey();
        }



    }
}
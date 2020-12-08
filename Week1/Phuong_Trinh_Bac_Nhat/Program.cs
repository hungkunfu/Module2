using System;

namespace Phuong_Trinh_Bac_Nhat
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            bool check;
            System.Console.Write("Nhap vao a :");
            check = double.TryParse(Console.ReadLine(), out a);
            while (!check)
            {
                System.Console.WriteLine("Nhap vao a :");
                check = double.TryParse(Console.ReadLine(), out a);
            }
            System.Console.Write("Nhap vao b :");
            check = double.TryParse(Console.ReadLine(), out b);
            while (!check)
            {
                System.Console.Write("Nhap vao a :");
                check = double.TryParse(Console.ReadLine(), out b);
            }
            if (a != 0)
            {
                System.Console.WriteLine("Phuong trinh co  nghiem = " + -b / a);
            }
            else
            {
                if (b == 0)
                {
                    System.Console.WriteLine("Phuong trinh vn");
                }
                else
                {
                    System.Console.WriteLine("Phuong Trinh vs nghiem");
                }

            }

        }
    }
}

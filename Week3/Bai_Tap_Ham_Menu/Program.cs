using System;

namespace Bai_Tap_Ham_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                System.Console.WriteLine("===========Menu===========");
                System.Console.WriteLine("1. Chuong Trinh Tinh Tong");
                System.Console.WriteLine("2. Chuong Trinh Tinh Tich");
                System.Console.WriteLine("3. Thoat");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        // System.Console.WriteLine($"{Tong()}");
                        Tong();
                        break;
                    case 2:
                        Tich();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;

                }
            }
        }


        static void Tong()
        {
            int a;
            int b;
            System.Console.WriteLine("Nhap vao gia tri a : ");
            a = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao gia tri b:");
            b = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine($" Tong = {a + b}");

        }
        static void Tich()
        {
            int a;
            int b;
            System.Console.WriteLine("Nhap vao gia tri a : ");
            a = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao gia tri b:");
            b = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine($" Tich = {a * b}");
        }


    }
}

using System;

namespace HienThiNamNhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool isLeapYear = false;
            System.Console.WriteLine("Nhap vao Nam de kiem tra");
            year = Convert.ToInt32(Console.ReadLine());
            while (year < 0)
            {
                System.Console.WriteLine("Nhap vao Nam de kiem tra");
                year = Convert.ToInt32(Console.ReadLine());

            }
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }
            if (isLeapYear)
            {
                System.Console.WriteLine("{0}  la nam nhuan ", year);
            }
            else
            {
                System.Console.WriteLine("{0}  khong phai nam nhuan", year);
            }
        }
    }
}


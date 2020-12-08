using System;

namespace Uoc_So_Chung_Lon_Nhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            System.Console.WriteLine("Nhap vao so a:");
            a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhap vao b :");
            b = Convert.ToInt32(Console.ReadLine());
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0)
            {
                System.Console.WriteLine("Khong co uoc so chung lon nhat");
            }
            else
            {
                while (a != b)
                {
                    if (a > b)
                        a = a - b;
                    else

                        b = b - a;
                }
                System.Console.WriteLine("uoc so chung lon nhat cua a =" + a);
            }
        }

    }
}

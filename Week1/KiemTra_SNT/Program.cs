using System;
using System.Text;

namespace KiemTra_SNT
{
    class Program
    {
        static void Main(string[] args)
        {
            // cách 1
            // int num;
            // System.Console.WriteLine(" Nhap vao so de kiem tra");
            // num = Convert.ToInt32(Console.ReadLine());
            // if (num < 2)
            // {
            //     System.Console.WriteLine(num + "khong phai la so nt");
            // }
            // else
            // {
            //     int i = 2;
            //     if(num == 2){
            //         System.Console.WriteLine(num + "so do la snt");
            //     }
            //     bool chek = true;
            //     for (i = 2; i < num; i++)
            //     {
            //         if (num % i == 0 || num < 2)
            //         {

            //             chek = false;

            //         }
            //         else if (chek)
            //         {
            //             System.Console.WriteLine(num + " " + "So do la snt");
            //             break;
            //         }
            //         else
            //         {
            //             System.Console.WriteLine(num + "khong phai la so nt");
            //             break;
            //         }
            //     }
            // }
            int number;
            System.Console.WriteLine("Nhap vap so de kiem tra");
            number = Convert.ToInt32(Console.ReadLine());
            while (number < 0)
            {
                System.Console.WriteLine("Nhap lai : ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            if (number < 2)
            {
                System.Console.WriteLine(number + " khong phai la snt");
            }
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                 if (check)
                {
                    System.Console.WriteLine(number + " " + "la so nguyen to");

                }
                else
                {
                    System.Console.WriteLine(number + " " + " khong phai");
                }

            }
        }
    }

}


using System;

namespace Bai_Tap_Tinh_Tong_Duong_Cheo_Chinh_Ma_Tran_vuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            Random rand = new Random();
            System.Console.WriteLine("=======Chuong trinh tinh tong duong cheo chinh========");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(10, 51);
                }
            }
            // in mang ra
            System.Console.WriteLine("Mang dc in ra ngau nhien ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.Write($" {arr[i, j]} ");
                }
                System.Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if( i==j ){
                        sum += arr[i,j]; 
                    }
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Tong duong cheo chinh = {sum}");
        }
    }
}

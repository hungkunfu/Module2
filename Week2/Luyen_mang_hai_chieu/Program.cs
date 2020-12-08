using System;

namespace Luyen_mang_hai_chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            int sum = 0;
            Random rand = new Random();
            System.Console.WriteLine("==========CHUONG TRINH SINH MANG NGAU NHIEN=========");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int total = 0;
                System.Console.WriteLine("");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10, 51);
                    sum += array[i, j];
                    total += array[i, j];
                    System.Console.Write($"  {array[i, j]} ");


                }
                // TINH TONG CAC COT CUA MANG
                System.Console.Write($"Tong Cot {i} phan tu mang = {total} ");


            }
            System.Console.WriteLine();
            // tinh tong tat ca cua mang
            System.Console.WriteLine($"Tong cac phan tu mang = {sum} ");

        }
    }
}

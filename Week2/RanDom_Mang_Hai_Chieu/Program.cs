using System;

namespace RanDom_Mang_Hai_Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[6, 6];
            // ham sinh so ngau nhien
            Random rand = new Random();
            int sum = 0;
        
            // int indexOfMaxround = 0;
            System.Console.WriteLine("=========Mang Hai Chieu Ngau Nhien=========");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                //tao bien luu gia tri tinh tog tung cot cua mang
                int totle = 0;
                // in ra mang
                System.Console.Write(" \n ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // in ra mang ngau nhien voi so 2-> 10
                    System.Console.Write($"  {array[i, j] = rand.Next(2, 10)} " + " ");

                    // tinh tong tat ca cac phan tu cua mang
                    sum += array[i, j];
                    // tinh tong tung cot cua mang
                    totle += array[i, j];

                }
                System.Console.WriteLine($" Tong cac cot thu {i} cua mang = {totle}");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine($" Tong tat ca cac phan tu mang = {sum}");


        }
    }
}

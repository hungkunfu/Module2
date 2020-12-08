using System;

namespace Bai_Tap_Tim_Phan_Lon_Nhat_Mang_Hai_Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10, 51);
                }
            }
            System.Console.WriteLine("Sinh mang voi phan tu ngau nhien ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write($" {array[i, j]} ");
                }
                System.Console.WriteLine();
            }
           
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }

            }
             System.Console.WriteLine($"Phan tu lon nhat cua mang la = {max} ");
        }
    }
}

using System;

namespace Bai_Tap_Tim_Gia_Tri_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            int size;
            bool check;
            do
            {
                System.Console.WriteLine("Nhap vao size");
                check = Int32.TryParse(Console.ReadLine(), out size);
            } while (!check || size <= 0);
            System.Console.WriteLine("Nhap vao gia tri cua mang");
            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine("Phan tu {0}", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Mang sau khi nhap");
            for (int i = 0; i < size; i++)
            {
                System.Console.Write($" {arr[i]} ");
            }
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Gia tri Min = {min}");
        }
    }
}

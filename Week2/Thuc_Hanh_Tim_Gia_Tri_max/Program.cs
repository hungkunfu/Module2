using System;

namespace Thuc_Hanh_Tim_Gia_Tri_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            bool check;
            int size;
            do
            {
                System.Console.WriteLine("Nhap vao size:");
                check = Int32.TryParse(Console.ReadLine(), out size);

            } while (!check || size < 0);
            arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine("Phan tu thu : " + (i + 1));
                arr[i] = Int32.Parse(Console.ReadLine());
                // System.Console.WriteLine($"{arr[i]}");
            }
            // hien thi mang da nhapzz
            System.Console.WriteLine("Mang Da nhap la :");
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write($" {arr[i]} ");
            }
            // tong ca phan tu mag
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Tong phan tu cau mang la = {sum}");
            // tim max trong mang:
            int Max = arr[0];
            int index = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                    index = i + 1;
                }
            }
            System.Console.WriteLine("Pham tu lon nhat cua mang la = " + Max);
        }
    }
}

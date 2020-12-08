using System;

namespace Thuc_Hanh_Dao_Nguoc_Mang
{
    class Program
    {
        static void Main(string[] args)
        {

            bool check;
            int[] arr;
            int size;
            do
            {
                // nhap size cua mang
                System.Console.WriteLine("Nhap vao Size");
                check = Int32.TryParse(Console.ReadLine(), out size);


            } while (!check || size > 20);
            // thuc thi chuong trinh
            arr = new int[size];
            // Nhap gia tri cua mang
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine("Nhap vao gia tri:" + (i + 1));
                arr[i]  = Int32.Parse(Console.ReadLine());
            }

            // in gia tri mang
            System.Console.WriteLine("Mang sau khi nhap:");
            for (int j = 0; j < arr.Length; j++)
            {
                System.Console.Write($" {arr[j]} ");
            }
            // Dao nguoc mang
            for (int j = 0; j < arr.Length / 2; j++)
            {
                int temp = arr[j];
                arr[j] = arr[size - 1 - j];
                arr[size - 1 - j] = temp;
            }
            // in ra mang khi convert
            System.Console.WriteLine();
            System.Console.WriteLine("Mang sau khi convert");
            for (int j = 0; j < arr.Length; j++)
            {
                System.Console.Write($" {arr[j]} ");
            }
        }
    }
}

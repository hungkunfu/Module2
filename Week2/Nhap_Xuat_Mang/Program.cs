using System;

namespace Nhap_Xuat_Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            
            bool check;
            int size;
            do
            {
                System.Console.WriteLine("Nhap vao size");
                check = Int32.TryParse(Console.ReadLine(), out size);

            } while (!check || size > 100 || size <= 0);
            // System.Console.Write($"Phan tu {0} :" + size);
            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine($"Phan tu {i + 1} ");
                array[i] = Int32.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Mang duoc in ra la");
            for (int i = 0; i < size; i++)
            {
                System.Console.Write($" {array[i]} ");
            }
            // dao nguoc mang 
            System.Console.WriteLine();
            System.Console.WriteLine("mang sau khi dc dao nguoc");
            for(int i = size - 1; i >= 0; i--){
                System.Console.Write($" {array[i]} ");
            }
        }
    }
}

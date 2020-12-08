using System;

namespace Tim_So_Phan_Tu_Giong_Nhau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rand = new Random();
            // int size;
            // bool check;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, 15);
            }
            System.Console.WriteLine("Cac phan tu cua mang la:");
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write($" {array[i]} ");
            }
            // tim phan tu giong nhau
            int dem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        dem++;
                        break;
                    }
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine($" so phan tu giong nhau la = {dem}");
        }
    }
}

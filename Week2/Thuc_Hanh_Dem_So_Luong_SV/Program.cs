using System;

namespace Thuc_Hanh_Dem_So_Luong_SV
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            int size;
            bool check;
            do
            {
                System.Console.WriteLine("Nhap vao size");
                check = Int32.TryParse(Console.ReadLine(), out size);
            } while (!check || size > 30);
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                System.Console.WriteLine("Nhap vao studen thu nhat:" + (i + 1) + ": ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;

            }
            int count = 0;
            System.Console.WriteLine("Lisk Of mark:");
            for (int j = 0; j < array.Length; j++)
            {
                System.Console.WriteLine(array[j] + "\t");
                if (array[j] >= 5 && array[i] <= 10)
                    // System.Console.WriteLine("");
                    count++;

            }
            System.Console.WriteLine("Sinh vien Thi do passsing:" + count);
            Console.ReadKey();
        }
    }
}

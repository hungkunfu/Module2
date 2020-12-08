using System;

namespace Thuc_Hanh_Tim_Gia_tri_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[19];
            
            Random rand = new Random();
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = rand.Next(-10, 30);
                 System.Console.Write($" {arr[j]}");
            }
           

            int index = minvalue(arr);
            System.Console.WriteLine();
            System.Console.WriteLine("Gia tri min = " + arr[index]);
        }
        static int minvalue(int[] array)
        {
            int min = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }
    }
}

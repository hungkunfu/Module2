using System;

namespace Sinh_Mang
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[100];
            
            // Random rand = new Random();
            System.Console.WriteLine("Nhap vao Mang:");
            // array = Console.ReadLine();
            for (int i = 0; i < array.Length; i++)
            {
            //    new array = {};
                // array[i] = rand.Next(10, 50);
                // array[i] = co
                // System.Console.Write($"{array} - ");

                array[i] = Int32.Parse(Console.ReadLine());
                if (array[i] == 0)
                {
                    Environment.Exit(0);
                }


            }
        }
    }
}

using System;

namespace Mang_Nhieu_Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            // nhaap vao mang tuw ban phim
            // System.Console.WriteLine("Nhap vao " + matrix.GetLength(0) + "rows and" + matrix.GetLength(1) + "colums");
            // for (int row = 0; row < matrix.GetLength(0); row++)
            // {
            //     for (int colum = 0; colum <  matrix.GetLength(1); colum++)
            //     {
            //         matrix[row, colum] = Int32.Parse(Console.ReadLine());

            //     }
            // }

            // ===== ham random tu sih mang
            Random rand = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine("\n");
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = rand.Next(2, 10);
                    Console.Write(matrix[row, column] + " ");

                }
            }
            // In mang ra 
            // for (int row = 0; row < matrix.GetLength(0); row++)
            // {
            //     Console.WriteLine("\n");
            //     for (int column = 0; column < matrix.GetLength(1); column++)
            //     {
            //         Console.Write(matrix[row, column] + " ");
            //     }
            // }


        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;

namespace DocFile_GhiFile_MangHaichieu
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\HungTran\Source\Repos\DocFile_GhiFile_MangHaichieu\Data";
            // tao moi thu muc
            Directory.CreateDirectory(filepath);
            string fileNameinput = "Input.txt";
            string fileNameoutput = "Output.txt";
            
            int[,] matrix = Matrix();
            List<int> arrlist = new List<int>();
            using (StreamWriter sw = new StreamWriter($@"{filepath}\{fileNameinput}"))
            {
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix.GetLength(1); j++)
                    {
                        sw.Write($"{matrix[i, j]} ");
                    }
                    sw.WriteLine();

                }
            }
            using (StreamReader rd = new StreamReader($@"{filepath}\{fileNameinput}"))
            {
                string line = string.Empty;
                while ((line = rd.ReadLine()) != null)
                {
                    line = line.Trim();
                    string[] list = line.Split(" ");
                    foreach (var item in list)
                    {
                        arrlist.Add(int.Parse(item));

                    }
                }
            }
            using (StreamWriter wt = new StreamWriter($@"{filepath}\{fileNameoutput}"))
            {
                wt.WriteLine($"Tong cac so Chan = {Sumsc(matrix)}");
                wt.WriteLine($"Tong cac duong cheo tren = {SumMaincross(matrix)}");
                wt.WriteLine($"Tong Duong cheo Phu = {SumSquash(matrix)}");
                wt.WriteLine($"Tong duong bien = {SumBorderline(matrix)}");

                wt.WriteLine("Print Matrix :  \n");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        wt.Write($"{matrix[i, j]} ");
                    }

                    wt.WriteLine();

                }
                wt.WriteLine("Print Matrix Up (ma tran duoi)");
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    wt.WriteLine();
                    for(int j = 0; j <= i; j++)
                    {
                        wt.Write($"{matrix[i, j]} ");
                    }
                }
                wt.WriteLine("\n");
                wt.WriteLine("Print Matrix Down (Ma tran tren)");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    wt.WriteLine();
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if(j >= i)
                        {
                            wt.Write($"{matrix[i, j]} ");
                        }else
                        {
                            wt.Write($"   ");
                        }
                       
                    }
                }
            }
        }
        static int[,] Matrix()
        {
            int[,] matrix = new int[5, 5];
            Random rand = new Random();
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j <matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(10, 81);
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
            return matrix;
            
        }
        static int Sumsc(int [,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
               
            }
            return sum;
        }
        static int SumSquash(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + j == matrix.GetLength(0) - 1)
                    {
                        sum += matrix[i, j];
                    }
                }

            }
            return sum;
        }
        static int SumMaincross(int [,] matrix)
        {
            int sum = 0;
            for(int i =0; i < matrix.GetLength(1); i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }
        static int SumBorderline(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = sum + matrix[i, 0] + matrix[i, matrix.GetLength(0)-1];
            }
            for (int j = 1; j < matrix.GetLength(1)-1; j++)
            {
                sum = sum + matrix[0, j] + matrix[matrix.GetLength(1) - 1, j];
            }
            return sum;

        }
       
    }
}

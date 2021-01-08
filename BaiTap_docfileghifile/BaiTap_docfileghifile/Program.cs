using System;
using System.IO;
using System.Collections.Generic;

namespace BaiTap_docfileghifile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\HungTran\Source\Repos\BaiTap_docfileghifile\Project";
            string fileNameInput = "InputData.txt";
            string fileNameOutput = "OutputData.txt";
            Directory.CreateDirectory(filepath);

            //Console.Write("Nhap Vao Row : ");
            //r = int.Parse(Console.ReadLine());
            //Console.Write("Nhap vao Colum : ");
            //c = int.Parse(Console.ReadLine());

            int Row = 0;
            int Colum = 0;
            using (StreamWriter wt = new StreamWriter($@"{filepath}\{fileNameInput}"))
            {
                wt.WriteLine($"{Row = 5} {Colum = 5}");
                int[,] matrix = Matrix(Row, Colum);
               
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix.GetLength(1); j++)
                    {
                        wt.Write($"{matrix[i, j]} ");
                    }
                    wt.WriteLine();
                }
            }
            int[,] matrixlist;
            
            using (StreamReader rd = new StreamReader($@"{filepath}\{fileNameInput}"))
            {
                string line = rd.ReadLine();              
                string[] list = line.Trim().Split(" ");
                Row = int.Parse(list[0]);
                Colum = int.Parse(list[1]);              
                matrixlist = new int[Row, Colum];
                int count = 0;
               while((line = rd.ReadLine())!= null)
                {
                    list = line.Trim().Split(" ");
                    for (int i = 0; i < list.Length; i++)
                    {
                        matrixlist[count, i] = int.Parse(list[i]);
                    }
                    count++;
                }
            }

            using (StreamWriter wt = new StreamWriter($@"{filepath}\{fileNameOutput}"))
            {
                //wt.writeline($"{row} {colum}");
                //for (int i = 0; i < matrixlist.getlength(0); i++)
                //{
                //    for (int j = 0; j < matrixlist.getlength(1); j++)
                //    {

                //            wt.write($"{matrixlist[i,j]} ");

                //    }
                //    wt.writeline();
                //}
                wt.WriteLine($"Sum so chan = {Sumsc(matrixlist)}\n");
                wt.WriteLine($"Sum duong bien = {SumBorderline(matrixlist)}\n");
                wt.WriteLine("Ma tran Nhan 3 ");
                Matrix3(matrixlist, wt);
                wt.WriteLine("số lần xuất hiện các giá trị có trong ma trân trên \n");
                statistical(matrixlist, wt);
                
            }

        }
        private static void statistical(int[,] matrixlist, StreamWriter wt)
        {
            Dictionary<int, int> statisticallist = new Dictionary<int, int>();

            for (int i = 0; i < matrixlist.GetLength(0); i++)
            {

                for (int j = 0; j < matrixlist.GetLength(1); j++)
                {
                    if (!statisticallist.ContainsKey(matrixlist[i, j]))
                    {
                        statisticallist.Add(matrixlist[i, j], 0);
                    }
                }
            }

            for (int i = 0; i < matrixlist.GetLength(0); i++)
            {
                for (int j = 0; j < matrixlist.GetLength(1); j++)
                {
                    statisticallist[matrixlist[i, j]]++;
                }
            }
            foreach (KeyValuePair<int, int> item in statisticallist)
            {
                wt.WriteLine($" so lan xuat hien so {item.Key} =  {item.Value} lan ");
            }

        }
        private static void Matrix3(int[,] matrixlist, StreamWriter wt)
        {
            for (int i = 0; i < matrixlist.GetLength(0); i++)
            {
                for (int j = 0; j < matrixlist.GetLength(1); j++)
                {

                    wt.Write($"{matrixlist[i, j] * 3} ");

                }
                wt.WriteLine();
            }
        }


        static int[,] Matrix (int r, int c)
        {
            int [,] matrix = new int[r,c];
            Random rand = new Random();
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    matrix[i, j] = rand.Next(4, 10);
                }
            }
            return matrix;
        }
        static int Sumsc(int [,] matrix)
        {
            int sum = 0;
            for(int  i = 0; i < matrix.GetLength(0); i++)
            {
                for(int  j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j ] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        static int SumBorderline(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = sum + matrix[i, 0] + matrix[i, matrix.GetLength(0) - 1];
            }
            for (int j = 1; j < matrix.GetLength(1) - 1; j++)
            {
                sum = sum + matrix[0, j] + matrix[matrix.GetLength(1) - 1, j];
            }
            return sum;
              
        }
       
        

    }
}

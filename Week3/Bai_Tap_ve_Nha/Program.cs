using System;
using System.Text;

namespace Bai_Tap_ve_Nha
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[0, 0];
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            while (true)
            {
                Menu();
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int rows, column;
                        System.Console.WriteLine("Nhap vao rows");
                        rows = Int32.Parse(Console.ReadLine());
                        System.Console.WriteLine("Nhap vao column");
                        column = Int32.Parse(Console.ReadLine());
                        array = Matrix(rows, column);
                        break;
                    case 2:
                        PrintMatrix(array);
                        break;
                    case 3:
                        System.Console.WriteLine($" Tong cac phan tu trong mang = {Sum(array)}");
                        break;
                    case 4:
                        System.Console.WriteLine($" So luong snt {CountPrime(array)}");
                        PrintPrimes(array);
                        break;
                    case 5:
                        Odd(array);
                        break;
                    case 6:
                        System.Console.WriteLine($"Tong duong bien = {SumAllSize(array)}");
                        break;
                    case 7:
                        int row;
                        System.Console.WriteLine("Nhap hang muon tinh:");
                        row = Int32.Parse(Console.ReadLine());
                        System.Console.WriteLine($" Tich cua hang {row} = { MultiplyRow(array, row)}");
                        break;
                        case 8:
                        int coulumn;
                        System.Console.WriteLine("Nhap vao Cot muon tinh :");
                        coulumn = Int32.Parse(Console.ReadLine());
                        System.Console.WriteLine($" Tich cua cot {coulumn} = {MultiplyColumn(array, coulumn)} ");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void Menu()
        {
            System.Console.WriteLine("========Menu Chon Bai Tap==========");
            System.Console.WriteLine("1. Sinh Matran So Nguyen ");
            System.Console.WriteLine("2. Hien Thi ma Tran");
            System.Console.WriteLine("3. Tinh Tong Gia Tri Trong Ma Tran");
            System.Console.WriteLine("4. So Luong So Nguyen To Co Trong Ma tran");
            System.Console.WriteLine("5.Số lượng số lẻ có trong ma trận");
            System.Console.WriteLine("6. Tổng giá trị trên đường biên");
            System.Console.WriteLine("7.Tính tích các giá trị trên 1 hàng");
            System.Console.WriteLine("8.Tính tích các giá trị trên 1 cột ");
            System.Console.WriteLine("0. Exit");
        }
        static int[,] Matrix(int rows, int column)
        {
            Random rand = new Random();
            // int rows, column;
            int[,] array = new int[rows, column];
            // int sum = 0;
            // string tmp = "";
            // string odd = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = rand.Next(10, 100);
                    
                }
                // System.Console.WriteLine();
            }
            return array;
           
        }
        static void PrintMatrix(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write($" {array[i, j]} ");
                }
                System.Console.WriteLine();
            }
        }
        static bool IsPrime(int N)
        {
            if (N < 2)
            {
                return false;
            }
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int CountPrime(int[,] array)
        {
            // int sum = 0;
            int count = 0;
            // string tmp = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (IsPrime(array[i, j]))
                    {
                        // tmp += array + ", ";
                        count++;
                    }
                }
            }
            return count;

        }
        static void PrintPrimes(int[,] array)
        {
            string tmp = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (IsPrime(array[i, j]))
                    {
                        tmp += array[i, j] + ", ";
                    }
                }
            }
            System.Console.WriteLine($" Cac So nguyen to la {tmp}");
        }
        // tong cac phan tu cua mang
        static int Sum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }
        // hien thi ra cac so le
        static void Odd(int[,] array)
        {
            string odd = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 1)
                    {
                        odd += array[i, j] + ", ";
                    }
                }
            }
            System.Console.WriteLine($" Cac so le cua mang la : {odd}");

        }
        // ham tinh tong cac duong bien
        static int SumAllSize(int[,] array)
        {
            int sumMatrix = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumMatrix += array[i, 0];
                sumMatrix += array[i, array.GetLength(1) - 1];
            }
            for (int j = 1; j < array.GetLength(1) - 1; j++)
            {
                sumMatrix += array[0, j];
                sumMatrix += array[array.GetLength(0) - 1, j];
            }

            return sumMatrix;
        }
        // tinh tich cua hang nhap vao
        static ulong MultiplyRow(int[,] array, int row)
        {
            ulong area = 1;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                area *= (ulong)array[row, i];
            }
            return area;

        }
        // tinh tich cua cot muon tinh
        static ulong MultiplyColumn(int[,] array, int coulumn)
        {
            ulong areacolumn = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                areacolumn *= (ulong)array[i, coulumn];
            }
            return areacolumn;

        }
    }
}


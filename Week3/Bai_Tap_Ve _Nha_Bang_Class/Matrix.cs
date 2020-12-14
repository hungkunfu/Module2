using System;
namespace Bai_Tap_Ve__Nha_Bang_Class
{
    public class Matrix
    {
        
        private int _row;
        public int Rows
        {
            get { return _row; }
            set { _row = value; }
        }
        private int _column;
        public int Column
        {
            get { return _column; }
            set { _column = value; }
        }
        // public 
        public Matrix() { }
        public Matrix(int row, int column)
        {
            _row = row;
            _column = column;

        }
        public void Menu(){

        }
        
        
        public int[,] Matrixs(int row, int column)
        {
            Random rand = new Random();
            int[,] arr = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr[i, j] = rand.Next(10, 101);
                }
            }
            return arr;
        }
        public void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.Write($" {arr[i, j]} ");
                }
                System.Console.WriteLine();
            }
        }
        public int SumMatrix(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }

            }
            return sum;
        }
        public int CountOdd(int[,] arr)
        {
            // string tmp = "";
            int odd = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 1)
                    {
                        odd++;

                    }
                }

            }
            return odd;

        }
        public bool IsPrime(int N)
        {
            if (N < 2)
            {
                return false;
            }
            for (int i = 0; i < N; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public int Count(int[,] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (IsPrime(arr[i, j]))
                    {
                        count++;
                    }
                }

            }
            return count;
        }

    }
}
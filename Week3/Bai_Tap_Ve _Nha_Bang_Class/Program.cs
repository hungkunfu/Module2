using System;
using System.Text;

namespace Bai_Tap_Ve__Nha_Bang_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int chocie;
            while (true)
            {
                Menu menu = new Menu();
                menu.Menus();
                chocie = int.Parse(Console.ReadLine());
                switch (chocie)
                {
                    case 1:
                        int row, column;

                        System.Console.WriteLine("Nhap vao Row");
                        row = Int32.Parse(Console.ReadLine());
                        System.Console.WriteLine("Nhap vao column");
                        column = Int32.Parse(Console.ReadLine());
                        System.Console.WriteLine("Ma tran dc sinh ra");
                        Matrix matrix = new Matrix(row, column);
                        int[,] arry = matrix.Matrixs(row, column);
                        matrix.PrintMatrix(arry);
                        break;
                        case 2:
                        
                    case 0:

                        Environment.Exit(0);
                        break;


                        // System.Console.WriteLine($" So luong so nguyen to =  {matrix.CountOdd(arry)} ");
                }
            }

        }
    }
}

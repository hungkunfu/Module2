using System;

namespace Hien_Thi_Cac_Loaj_Hinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("===========MENU=========");
                System.Console.WriteLine("1. Print the rectange");
                System.Console.WriteLine("2. Print the square triangle");
                System.Console.WriteLine("3. Print isosceles triagle");
                System.Console.WriteLine("4. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        System.Console.WriteLine("1. Print the rectange");
                        for (int i = 0; i < 3; i++)
                        {
                            System.Console.WriteLine("");
                            for (int j = 0; j < 7; j++)
                            {
                                System.Console.Write("*");
                            }
                        }
                        break;
                    case 2:
                        System.Console.WriteLine("2. Print the square triangle");
                        for (int i = 0; i <= 5; i++)
                        {
                            System.Console.WriteLine("");
                            for (int j = 0; j < i; j++)
                            {
                                System.Console.Write("*");
                            }
                        }
                        break;
                    case 3:
                        System.Console.WriteLine("3. Print isosceles triagle");
                        for (int i = 7; i >= 1; i--)
                        {
                            System.Console.WriteLine("");
                            for (int j = 1; j <= i; j++)
                            {
                                System.Console.Write("*");
                            }
                        }
                        break;
                        case 4:
                        Environment.Exit(0);
                        break;


                }
            }
        }
    }
}

using System;

namespace ThietKe_MeNu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                System.Console.WriteLine("==============MENU=============");
                System.Console.WriteLine("1. giao dien menu 1");
                System.Console.WriteLine("2. giao dien menu 2");
                System.Console.WriteLine("3. giao dien menu 3 ");
                System.Console.WriteLine("0. exit");
                System.Console.WriteLine("Enter continue");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        System.Console.WriteLine("1. giao dien 1 ");
                        System.Console.WriteLine("==============");
                        System.Console.WriteLine("============");
                        System.Console.WriteLine("=========");
                        System.Console.WriteLine("=======");
                        System.Console.WriteLine("=====");
                        System.Console.WriteLine("==");
                        break;
                    case 2:
                        System.Console.WriteLine("2. giao dien 2");
                        System.Console.WriteLine("+++++++++");
                        System.Console.WriteLine("+++++++++");
                        System.Console.WriteLine("=========");
                        System.Console.WriteLine("=======");
                        System.Console.WriteLine("=====");
                        System.Console.WriteLine("==");

                        break;
                    case 3:
                        System.Console.WriteLine("Draw the rectangle");
                        System.Console.WriteLine("* * * * * *");
                        System.Console.WriteLine("* * * * * *");
                        System.Console.WriteLine("* * * * * *");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.WriteLine("khong tong tai!");
                        break;


                }

            }
        }
    }
}

using System;

namespace Hien_Thi_SNT_Nho_Hon100
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            System.Console.WriteLine("Danh sach SNT");
            for (int i = 2; i < 100; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    System.Console.Write($"{i} - ");
                }
                count = 0;



            }
        }
    }
}

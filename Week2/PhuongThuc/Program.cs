using System;

namespace PhuongThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========Phuong Thuc==========");
            System.Console.WriteLine($"Tong SN tu 1 - > 10 =  {sum(1, 10)}");
            System.Console.WriteLine($"Togn SN tu 20 - > 40 = {sum(20, 40)}");
        }
        public static int sum(int input, int newInput)
        {
            int result = 0;
            for (int i = input; i < newInput; i++)
            {
                result += i;
            }
            return result;
        }
    }
}

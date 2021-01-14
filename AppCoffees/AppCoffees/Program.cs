using System;
using System.Text;

namespace AppCoffees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Menu.MainCoffee();
        }
    }
}

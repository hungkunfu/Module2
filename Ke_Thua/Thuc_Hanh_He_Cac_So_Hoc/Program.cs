using System;

namespace Thuc_Hanh_He_Cac_So_Hoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();

            Console.WriteLine(shape);



            shape = new Shape("red", false);

            Console.WriteLine(shape);

            Console.WriteLine("Hello World!");
        }
    }
}

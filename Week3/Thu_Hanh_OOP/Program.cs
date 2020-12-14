using System;

namespace Thu_Hanh_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // int 
            bool check;
            int widths, heights;
            do
            {

                System.Console.WriteLine("Nhap vao chieu dai ");
                check = Int32.TryParse(Console.ReadLine(), out widths);
                System.Console.WriteLine("Nhap vao chieu rong ");
                check = Int32.TryParse(Console.ReadLine(), out heights);
            } while (!check);
            newclass output = new newclass(widths, heights);
            System.Console.WriteLine($" {output.Print()}");
            System.Console.WriteLine($" Dien tich =  {output.GetArea()}");
            System.Console.WriteLine($"Chu Vi =  {output.Getprimeter()}");
        }
    }
}
  
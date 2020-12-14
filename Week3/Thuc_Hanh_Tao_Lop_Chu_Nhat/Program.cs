using System;

namespace Thuc_Hanh_Tao_Lop_Chu_Nhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;
            System.Console.Write("Nhap vao chieu dai = ");
            width = Int32.Parse(Console.ReadLine());
            System.Console.Write("Nhap vao chieu rong = ");
            height = Int32.Parse(Console.ReadLine());
           Rectangle output = new Rectangle(width,height);
           System.Console.WriteLine($"{output.Display()}"); 
           System.Console.WriteLine($" Dien tich =  {output.GetArea()} ");
           System.Console.WriteLine($" Chu vi =  {output.GetPerimeter()}");
        }
    }
}

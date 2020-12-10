using System;

namespace Thuc_Hanh_Lop_Hinh_Chu_Nhat
{
    class Program
    {
         static void Main(string[] args)
        {

            System.Console.WriteLine("== Chuong trinh tao lop chu nhat=== ");
            Rectangle output = new Rectangle(10, 30);
            System.Console.WriteLine($"Dien tich hinh chu nhat la = {output.Getarea()}");
            System.Console.WriteLine($"Chu vu hinh chu nhat la= {output.CV()}");
            System.Console.WriteLine($"print = {output.Display()}");
        }

    }
    public class Rectangle
    {
        double height;
        double width;
        // public Rectangle()
        // {

        // }
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public double Getarea()
        {
            return (this.width * this.height);
        }
        public double CV()
        {
            return (this.width + this.height) * 2;
        }
        public string Display()
        {
            return " Rectangle " + " with " + width + " hight " + height;
        }
    }

}

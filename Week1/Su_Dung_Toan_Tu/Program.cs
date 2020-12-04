using System;

namespace Su_Dung_Toan_Tu
{
    class Program
    {
        static void Main(string[] args)
        {
          float hight;
          float width;
         System.Console.WriteLine("Nhap vao hight:");
         hight = float.Parse(Console.ReadLine());
         System.Console.WriteLine("Nhap vao width:");
         width = float.Parse(Console.ReadLine());
         float area = width * hight;
         System.Console.WriteLine("area = " + area);
        }
    }
}

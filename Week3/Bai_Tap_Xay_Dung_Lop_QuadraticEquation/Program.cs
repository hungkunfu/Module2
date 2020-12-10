using System;

namespace Bai_Tap_Xay_Dung_Lop_QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            // QuadraticEquatio output = new QuadraticEquatio();
            System.Console.WriteLine("Nhap vao a :");
            double a = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao b :");
            double b = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao c :");
            double c = Int32.Parse(Console.ReadLine());
            QuadraticEquatio output = new QuadraticEquatio(a, b, c);
            System.Console.WriteLine($" detla  =   {output.GetDiscriminant()}");
            double delta = output.GetDiscriminant();
            if (delta > 0)
            {
                System.Console.WriteLine("phuong trinh co hai nghiem");
                System.Console.WriteLine($"Nghiem x1 = {output.GetRoot1()}");
                System.Console.WriteLine($"Nghiem x2 = {output.GetRoot2()}");
            }
            else if (delta == 0)
            {
                System.Console.WriteLine("Phuong trinh co nghiem kep");
                System.Console.Write($" x1 = x2 = {-b / (2 * a)}");

                // System.Console.WriteLine();
            }
            else
            {
                System.Console.WriteLine("Phuong Trinh vo nghiem");
            }




        }
    }
    public class QuadraticEquatio
    {
        private double _a;
        private double _b;
        private double _c;
        double x1;
        double x2;
        double delta;
        public double A
        {
            get{ return _a ;}
            set{ _a = value;} 
        }
         public double B
        {
            get{ return _b ;}
            set{ _b = value;} 
        }
         public double C
        {
            get{ return _c ;}
            set{ _c = value;} 
        }
        public QuadraticEquatio(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            // double delta;


        }
        public double GetDiscriminant()
        {
            return delta = (B*B) - (4*A*C);
        }
        public double GetRoot1()
        {
            return x1 = (-B - Math.Sqrt(delta)) / (2 * A);
        }
        public double GetRoot2()
        {
            return x2 = (-B + Math.Sqrt(delta)) / (2 * A);
        }
    }
}

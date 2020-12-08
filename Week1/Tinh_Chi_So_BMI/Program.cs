using System;

namespace Tinh_Chi_So_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
            System.Console.WriteLine("Nhap vao chieu cao");
            height = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao can a");
            weight = float.Parse(Console.ReadLine());
            double BMI = weight / Math.Pow(height,2);
            BMI = Math.Round(BMI, 1);
             Console.Write("BMI: "+ BMI);
            if (BMI < 18)
                Console.WriteLine(" Underweight");
            else if (BMI < 25.0)
                Console.WriteLine(" Normal");
            else if (BMI < 30.0)
                Console.WriteLine(" Overweight");
            else
                Console.WriteLine(" Obese");
        }
    }
}

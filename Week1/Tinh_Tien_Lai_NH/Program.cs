using System;

namespace Tinh_Tien_Lai_NH
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 1.0;
            int month = 1;
            double rate = 1.0;
            System.Console.WriteLine("Nhap vao so tien can gui:");
            money = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao may thang gui:");
            month = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao lai suat:");
            rate = Double.Parse(Console.ReadLine());
            double Bankinterestrate = 0;
            for(int i = 1; i < month; i++){
                Bankinterestrate = money * (rate/100)/12 * 3;
            }
            System.Console.WriteLine("Lai suat thu dc la :" + Bankinterestrate);
        }
    }
}

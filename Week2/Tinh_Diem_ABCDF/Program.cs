using System;

namespace Tinh_Diem_ABCDF
{
    class Program
    {
        static void Main(string[] args)
        {
            // do{

            //     bool check;
            //     double input = 0;
            //    System.Console.WriteLine("Nhap vao Diem De Kiem Tra");
            //    check = double.TryParse(Console.ReadLine(),out input);

            // }while(!check || input < 0);
            //  System.Console.WriteLine("Xep Loai");
            System.Console.WriteLine(Diem(0.0));

        }
        public static double Diem(double Input)
        {
          
            
            if (Input >= 90.0)
            {
                System.Console.Write(" A ");
            }
            else if (Input >= 80.0)
            {
                System.Console.Write(" B ");
            }
            else if (Input >= 70.0)
            {
                System.Console.Write(" C ");
            }
            else if (Input >= 60.0)
            {
                System.Console.Write(" D  ");
            }
            else
            {
                System.Console.Write(" F ");
            }
            return Input;
        }
    }
}

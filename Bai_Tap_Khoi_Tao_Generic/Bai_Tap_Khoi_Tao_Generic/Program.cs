using System;

namespace Bai_Tap_Khoi_Tao_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList list = new GenericList();
            int a = 6;
            int b = 6;
            list.compares<int>( a,   b);
        
            if (list.compares<int>( a,  b))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            string sr = "hung tran";
            string st = "Dieu Hanh";
            
            if (list.compares<string>(sr, st))
            {
                Console.WriteLine("true");
            }else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();
        }
    }
}

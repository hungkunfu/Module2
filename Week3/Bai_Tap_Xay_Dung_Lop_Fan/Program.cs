using System;

namespace Bai_Tap_Xay_Dung_Lop_Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("=======Mo Ta Lop FAN=========");
            Fan fan1 = new Fan();
            Fan fan2 = new Fan(3,5 , "yelow", 5);
            fan1.ToString();
            fan2.ToString();
        }
    }
}

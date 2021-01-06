using System;

namespace TH_Đe_Quy
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset begin = DateTimeOffset.Now;
            int n = 10000;
            Console.WriteLine(begin.Millisecond);
            Console.WriteLine($" {n} = {DQ(n)}");
            DateTimeOffset end = DateTimeOffset.Now;
            Console.WriteLine(end.Millisecond);
            Console.WriteLine(end.Millisecond- begin.Millisecond);
        }
        public static long DQ(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            return n + DQ(n - 1);
        }
        public static long KDQ(int n)
        {
            long total = 0;
            for(int i = 0; i <= n; i++)
            {
                total = total + i;
            }
            return total;
        }
    }
}

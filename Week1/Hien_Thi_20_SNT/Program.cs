using System;

namespace Hien_Thi_20_SNT
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool check;
            int count = 0;
            int N = 2;
            do
            {
                System.Console.Write("Nhap vao Number:");
                check = int.TryParse(Console.ReadLine(), out number);

            } while (!check || number <= 0);
            while(count < number){
                if(kTraSNT(N)){
                    System.Console.Write($"{N} - ");
                    count ++;
                }
                N++;
            }

        }
        static bool kTraSNT(int N)
        {
            if(N < 2){
                return false;
            }
            for(int i = 2; i < N; i++)
            {
                if(N%i ==0){
                    return false;
                }
            }
            return true;
        }

    }

}

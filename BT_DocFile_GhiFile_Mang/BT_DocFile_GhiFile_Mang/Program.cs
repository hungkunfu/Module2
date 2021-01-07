using System;
using System.IO;
using System.Collections.Generic;

namespace BT_DocFile_GhiFile_Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\HungTran\Source\Repos\BT_DocFile_GhiFile_Mang/Data";
            Directory.CreateDirectory(filepath);
            string fileName = "Input.txt";
            string fileName2 = "Output.txt";
            string fileName3 = "OutPutSum.txt";
            List<int> arrlist = new List<int>();
            int[] arr =  MatrixArray();
           
            using(StreamWriter wt = new StreamWriter($@"{filepath}\{fileName}"))
            {
                foreach (var item in arr)
                {
                     wt.Write($" {item} ");
                }

            }
            using(StreamReader rd = new StreamReader($@"{filepath}\{fileName}"))
            {
                string line = string.Empty;
                while((line = rd.ReadLine())!= null)
                {
                    line = line.Trim();
                    string[] list = line.Split("  ");
                    foreach (var item in list)
                    {
                        arrlist.Add(int.Parse(item));
                        
                    }
                }
            }

            using (StreamWriter wts = new StreamWriter($@"{filepath}\{fileName2}"))
            {
                foreach (var item in arrlist)
                {
                    wts.Write($" {item * 2} ");
                }
            }
            using(StreamWriter old = new StreamWriter($@"{filepath}\{fileName3}"))
            {

                old.Write( $" so luong So le :{chek2(arr)}\n");
                
                old.WriteLine($"So luong so chan : {Isodd(arr)}\n");
                old.WriteLine($"so luong so ngt : {snt(arr)}");

            }
        }
        static int[] MatrixArray()
        {
            int[] arr = new int[5];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10, 21);
            }
            return arr;
        }
        static int Isodd(int[] arr)
        {
            int old= 0;
            int count = 0;
            for(int i =0; i < arr.Length; i ++)
            {
                if(arr[i] % 2== 0)
                {
                    count++;
                     old = arr[i];
                }
            }
            return count;
        }
        static int chek2(int[] arr)
        {
            int count = 0;
            for(int i = 0; i <arr.Length; i++)
            {
                if(arr[i] %2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
        static bool Isprime(int N)
        {
            if(N < 2)
            {
                return false;
            }
            for(int i = 2; i < N; i++)
            {
                if(N%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int snt(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
               
                if (Isprime(arr[i]))
                {
                    
                    count++;
                }
            }
            return count;

        }
    }
}

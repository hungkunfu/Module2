using System;

namespace Bai_Tap_Gop_Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrx = new int[50];
            int[] arry = new int[50];
            int[] arrz = new int[50];
            int sizex;
            int sizey;
            int sizez;
            int i,j;
          

            System.Console.WriteLine("=========CHUONG TRINH GOP MANG========");
            System.Console.WriteLine("Nhap vao size mang x");
            sizex = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao size mang x", sizex);

            for ( i = 0; i < sizex; i++)
            {
                System.Console.WriteLine("phan tu {0}", i + 1);
                arrx[i] = Int32.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Nhap vao size mang y");
            sizey = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao size mang y", sizey);


            for ( i = 0; i < sizey; i++)
            {
                System.Console.WriteLine("phan tu {0} ", i + 1);
                arry[i] = Int32.Parse(Console.ReadLine());
            }
            // in mang thu nhat 
            System.Console.WriteLine("=====Mang sizex======");
            for ( i = 0; i < sizex; i++)
            {
                System.Console.Write($" {arrx[i]} ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("=====Mang sizey======");
            for ( i = 0; i < sizey; i++)
            {
                System.Console.Write($" {arry[i]} ");
            }
            // gop hai mang thanh mot
            System.Console.WriteLine();
            System.Console.WriteLine("=====SIZE cua mang la=======");
            sizez = sizex + sizey;
            System.Console.WriteLine($" {sizez} ");
            for ( i = 0; i < sizex; i++)
            {
                arrz[i] = arrx[i];
            }
            for ( j = 0; j < sizey; j++)
            {
                arrz[i] = arry[j];
                i++;
            }

            System.Console.WriteLine("=====Mang sau khi gop===== ");
            for ( i = 0; i < sizez; i++)
            {
                System.Console.Write($" {arrz[i]} ");
            }
        }
    }
}

using System;

namespace Bai_Tap_Xoa_Phan_Tu_Cua_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            // in cac pha tu cua mang nhap tu ban phim
            int i, del, size; //pos la vi tri can xoa
            int[] arr1 = new int[50];


            Console.Write("\nXoa phan tu trong mang C#:\n");
            Console.Write("---------------------------\n");

            Console.Write("Nhap kich co mang: ");
            size = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao mang theo thu tu tang dan:\n", size);
            for (i = 0; i < size; i++)
            {
                Console.Write("Phan tu - {0}: ", i + 1);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nNhap vi tri can xoa: ");
            del = Convert.ToInt32(Console.ReadLine());
            /* xac dinh vi tri cua i trong mang*/
            i = 0;
            while (i != del - 1)
                i++;
            /*vi tri i trong mang se duoc thay the boi gia tri ben phai cua no */
            while (i < size)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            size--;
            Console.Write("\nIn mang sau khi da xoa phan tu: ");
            for (i = 0; i < size; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();

        }
    }
}

using System;

namespace Bai_Tap_Them_Phan_Tu_Vao_Mang
{
    public class MainClass
    {
        public static void Main()
        {
            int[] arr = new int[10];
            int i, size, p, x;

            Console.Write("\nChen phan tu vao mang trong C#: \n");
            Console.Write("--------------------------------\n");
            Console.Write("Nhap kich co mang: ");
            size = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao trong mang:\n", size);
            for (i = 0; i < size; i++)
            {
                Console.Write("Phan tu - {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Nhap gia tri phan tu moi can chen: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri can chen phan tu moi nay: ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("In mang ban dau:\n");
            for (i = 0; i < size; i++)
                Console.Write("{0} ", arr[i]);
            /* di chuyen vi tri cac phan tu ben phai cua mang */
            for (i = size; i >= p; i--)
                arr[i] = arr[i - 1];
            /* chen gia tri vao vi tri da cho */
            arr[p - 1] = x;


            Console.Write("\n\nSau khi chen phan tu, mang co dang:\n");
            for (i = 0; i <= size; i++)
                Console.Write("{0} ", arr[i]);
            Console.Write("\n\n");

            Console.ReadKey();
        }


    }
}
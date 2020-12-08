using System;

namespace Thuc_Hanh_Tim_Gia_Trị_Trong_Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studen = { "Hung Tran", "Phuc you", "Hieu", "Dieu Hanh", "Tan Ba Den" };
            System.Console.WriteLine("Nhap vao ten muon tim kiem");
            string new_studen = Console.ReadLine();
            bool check = false;
            for (int i = 0; i < studen.Length; i++)
            {
                if (studen[i].Equals(new_studen))
                {
                    System.Console.WriteLine("Vi tri sinh vien trong danh sach " +  new_studen  + " la : " + (i+1));
                    check = true;
                    break;
                }

            }
            if(!check){
                System.Console.WriteLine("Khong tim thay " + ":" + new_studen);
            }
        }
    }
}

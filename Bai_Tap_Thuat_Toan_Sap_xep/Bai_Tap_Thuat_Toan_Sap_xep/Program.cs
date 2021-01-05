using System;

namespace Bai_Tap_Thuat_Toan_Sap_xep
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[0];
            int n;
            int choice;
            bool check;
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("=========MENU==========");
                Console.WriteLine("1. Tao Mang");
                Console.WriteLine("2. Kiem tra doi xung");
                Console.WriteLine("3. Sap Xep Mang");
                Console.WriteLine("4. Tim Kiem mang");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter options ");
                do
                {
                    check = int.TryParse(Console.ReadLine(), out choice);
                } while (!check || choice < 1 || choice > 5);

                switch (choice)
                {
                    case 1:
                        bool checkn;
                        do
                        {
                            Console.WriteLine("Nhap vao N : ");
                            checkn = int.TryParse(Console.ReadLine(), out n);
                        } while (!checkn);

                        arr = AddAraay(n);

                        break;
                    case 2:
                        Console.WriteLine("Kiem tra doi xung khong");
                        if (IsSymmetryArray(arr) == true)
                        {
                            Console.WriteLine("Mang Doi Xung");
                        }
                        else
                        {
                            Console.WriteLine("Mang Khong doi xung");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Mang sap xep tang dan theo Phuong Phap chon :");
                        SelectionSort(arr);
                        PrintSelectionSort(arr);
                        break;
                    case 4:

                        if (checkSort(arr) == false)
                        {
                            Console.WriteLine("Mang chua sap sep khong tim thay ban hay sap sep gium");

                        }
                        else
                        {
                            Console.WriteLine("Nhap vao input");
                            int input = int.Parse(Console.ReadLine());
                            if (Find(arr, input) != -1)
                            {
                                Console.WriteLine($"Vi tri {input} la thu {Find(arr, input)}");
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay ");
                            }
                        }
                       
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }

        }
        public static int[] AddAraay(int n)
        {

            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(30, 61);
                Console.Write($" {arr[i]} - ");
            }
            return arr;

        }
        static bool IsSymmetryArray(int[] arr)
        {

            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] == arr.Length - i)
                {
                    return true;
                }
            }
            return false;

        }
        static void SelectionSort(int[] arr)
        {
            bool check = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
                check = true;
            }
            if (check == true)
            {
                Console.WriteLine("Mang da sap sep tang dan");
            }
            else
            {
                Console.WriteLine("Mang chua sap sep");
            }

        }
        static void PrintSelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i] } - ");
            }
        }
        static int Find(int[] arr, int input)
        {
            
            int low = 0;
            int hight = arr.Length - 1;
            while (hight >= low)
            {
                int mid = (low + hight) / 2;
                if (input < arr[mid])
                {
                    hight = mid - 1;
                }
                else if (input == arr[mid])
                {
                    return mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
        //static int IndexOf(int[] arr, int index)
        //{
        //    int count = 0;
        //    if (Find(arr, index) != -1)
        //    {
        //        for (int i = Find(arr, index); i < arr.Length; i++)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        static bool checkSort(int[] arr)
        {

            for (int i = 0; i < arr.Length -1; i++)
            {

                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        //static int IsValidate()
        //{
        //    if()
        //}
    }
}

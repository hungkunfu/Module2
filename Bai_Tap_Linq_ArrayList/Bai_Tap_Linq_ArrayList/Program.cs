using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
namespace Bai_Tap_Linq_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Staff staff = new Staff();
            int choice;
            while (true)
            {
                Console.WriteLine("=====menu=====");
                Console.WriteLine("1 . Add vao danh sach");
                Console.WriteLine("2. Danh sach chua sap xep:");
                Console.WriteLine("3. Danh sach da dc sap xep theo ten va tuoi < 24");
                Console.WriteLine("4 . Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Staff p = new Staff();
                        staff.Add(p);
                       
                        break;
                    case 2:
                        Console.WriteLine("====Danh sach ====");
                        Console.WriteLine("ID\t\t\tName\t\t\tAGE");
                        staff.PrintStaff();
                        break;
                    case 3:
                        Console.WriteLine("Danh sach nho hoon 24 tuoi va sap sep theo ten ");
                        staff.staffList.Sort(new SortName());
                        //SortName sortName = new SortName();
                        //staff.staffList.Sort((IComparer)sortName);
                        staff.FilterStaffList();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

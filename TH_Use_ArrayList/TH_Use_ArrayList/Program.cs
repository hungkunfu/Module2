using System;
using System.Collections;

namespace TH_Use_ArrayList
{
    class Program
    {
       public static ArrayList studenlist = new ArrayList(); 
        static void Main(string[] args)
        {
            studenlist.Add(new Student { Name = "Hung tran", Age = 20 });
            studenlist.Add(new Student { Name = "Dieu Hanh", Age = 22 });
            studenlist.Add(new Student { Name = "le tran", Age = 20 });
            studenlist.Add(new Student { Name = "Dieu h", Age = 22 });
            studenlist.Add(new Student { Name = "Hung hung", Age = 24 });
            studenlist.Add(new Student { Name = "hanh Hanh", Age = 19 });
            foreach (Student item in studenlist)
            {
                Console.WriteLine(item.ViewInfo());
            }
            studenlist.RemoveAt(3);
            Console.WriteLine();
            foreach (Student item in studenlist)
            {
                Console.WriteLine(item.ViewInfo());
            }
        }
    }
}

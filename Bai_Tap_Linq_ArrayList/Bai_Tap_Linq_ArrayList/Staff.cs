using System;
using System.Collections;
using System.Collections.Generic;

namespace Bai_Tap_Linq_ArrayList
{
    public class Staff 
    {

       
       public List<Staff> staffList = new List<Staff>();
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Staff() { }
        public string ViewInfo()
        {
            return $"{_id}\t\t\t{_name}\t\t\t{_age}";
        }
        public void Add(Staff p)
        {
            Console.Write("Nhap vao Id: ");
            p.Id = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Nhap vao Age: ");
            p.Age = int.Parse(Console.ReadLine());
            staffList.Add(p);
        }
        public void PrintStaff()
        {
            foreach (Staff p in staffList)
            {
                Console.WriteLine(p.ViewInfo());
            }
        }
        public void FilterStaffList()
        {
            
            foreach (Staff p in staffList)
            {
                
                if (p.Age < 24 )
                {
                    Console.WriteLine(p.ViewInfo());
                }
            }
          
        }
      


    }
  }

using System;
using System.Collections.Generic;
using System.Text;

namespace TH_Use_ArrayList
{
    class Student
    {
        public string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Student() { }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string ViewInfo()
        {
            return $"{_name}\t\t\t{_age}";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Thuc_Hanh_IComparer
{
    class Circle
    {
        public double darius;
        public string test;
        bool check;
        public double getDarius()
        {
            return darius;
        }
        public Circle()
        {

        }
        public Circle(double darius)
        {
            this.darius = darius; 
        }
        public Circle(double darius, string test, bool check)
        {
            this.darius = darius;
            this.test = test;
            this.check = check;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Thuc_Hanh_IComparer
{
    class CircleComparator : IComparer<Circle>  
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.getDarius() > c2.getDarius()) return 1;
            else if (c1.getDarius() < c2.getDarius()) return -1;
            else return 0;
        }

       
    }
}

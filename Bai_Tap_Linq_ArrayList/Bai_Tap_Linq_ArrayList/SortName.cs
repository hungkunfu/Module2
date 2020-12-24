using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap_Linq_ArrayList
{
    class SortName : IComparer<Staff>
    {
            public int Compare(Staff x, Staff y)
            {
                return x.Name.CompareTo(y.Name);
            }
        
    }
}

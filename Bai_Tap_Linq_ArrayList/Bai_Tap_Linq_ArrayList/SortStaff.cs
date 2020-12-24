using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap_Linq_ArrayList
{
    class SortStaff : IComparer
    {
        public int Compare(object x, object y)
        {
            // Ép kiểu 2 object truyền vào về Person.
            Staff p1 = x as Staff;
            Staff p2 = y as Staff;

            if (p1 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {

                if (p1.Age > p2.Age)
                {
                    return 1;
                }
                else if (p1.Name == p2.Name)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }

       
    }
}

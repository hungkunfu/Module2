using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap_Khoi_Tao_Generic
{
    class GenericList
    {
        public bool compares<T>( T a,  T b)
        {
           
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;

            }
    
        }
    }
}

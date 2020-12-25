using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap_Collection_Generic
{
    class MyList<T>
    {
            public T[] list;
            public int Count = 0;
            public int Capacity { get; set; }
            
            public MyList()
            {

                Capacity = 0;
                list = new T[Capacity];
            }

            // index ser
            public T this[int index]
            {
                get
                {
                    if (index >= 0 && index < Count)
                    {
                        return list[index];
                    }
                    throw new IndexOutOfRangeException();
                }
                set
                {
                    if (index >= 0 && index < Count)
                    {
                        list[index] = value;
                    }
                    throw new IndexOutOfRangeException();
                }
            }
            public int Add(T item)
            {
              
                if (Capacity == 0)
                {
                    Capacity = 4;
                    Array.Resize(ref list, Capacity);
                }
                else if (Count >= Capacity)
                {
                    Capacity *= 2;
                    Array.Resize(ref list, Capacity);
                }

                list[Count++] = item;
            return Count - 1;
            }

      
             public int IndexOf(T searchitem)
             {
                for(int i = 0; i < Count; i++)
                {
                if (list[i].Equals(searchitem))
                    {
                         return i;
                    }
                    
                 }
                return -1;
             }
            public bool Remove(T item)
            {
                if(IndexOf(item) != -1)
                 {
                     for(int i = IndexOf(item); i < Count - 1; i++)
                     {
                       list[i] = list[i + 1];
                     }
                     list[Count - 1] = default(T);
                      Count--;
                     return true;
                }
                return false;
             }
     
        
         }
}


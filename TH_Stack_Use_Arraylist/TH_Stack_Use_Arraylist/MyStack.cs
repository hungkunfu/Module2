using System;
using System.Collections.Generic;
using System.Text;

namespace TH_Stack_Use_Arraylist
{
    class MyStack
    {
        private int[] arr;
        private int size;
        private int index = 0;
        public MyStack(int size)
        {
            this.size = size;
            arr = new int[size];

        }
        public bool isEmpty()
        {
            if(index == 0)
            {
                return false;
            }
            return true;
        }
        public bool isFull()
        {
            if(index == size)
            {
                return true;
            }
            return false;
        }
        public int Size()
        {
            return index;
        }
        public void Push(int element)
        {
            if (isFull())
            {
                throw new Exception("Stack IS full");
            }
            arr[index] = element;
            index ++;
        }
        public int Pop()
        {
            if (isEmpty())
            {
                throw new Exception("Stack IS null");
            }
            return arr[--index];
        }

    }
}

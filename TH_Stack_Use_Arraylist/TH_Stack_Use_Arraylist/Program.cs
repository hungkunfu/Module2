using System;

namespace TH_Stack_Use_Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack(10);

            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Push(7);
            stack.Push(8);
            Console.WriteLine("1. Size of stack after push operations: " + stack.Size());
            Console.WriteLine("2. Pop elements from stack : ");

            while (!stack.isEmpty())
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("\n3. Size of stack after pop operations : " + stack.Size());
            Console.ReadKey();
        }
    }
}

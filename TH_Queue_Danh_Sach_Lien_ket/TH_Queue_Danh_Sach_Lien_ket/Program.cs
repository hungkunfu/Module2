using System;

namespace TH_Queue_Danh_Sach_Lien_ket
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedListQueue queue = new MyLinkedListQueue();
            queue.Enqueue(10);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            queue.Enqueue(20);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            Console.ReadKey();
        }
    }
}

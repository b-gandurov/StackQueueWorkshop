using StackQueueWorkshop.Queue;
using System;

class Program
{
    static void Main(string[] args)
    {
        IQueue<int> queue = new ArrayQueue<int>();
        queue.Enqueue(5);
        queue.Enqueue(6);
        queue.Enqueue(7);
        queue.Enqueue(8);
        queue.Enqueue(9);
        Console.WriteLine("Head is " + queue.Head);
        Console.WriteLine("Occupied cells are " + queue.Size);
        Console.WriteLine("Capacity of queue is " + queue.Capacity);
        var elementToremove = queue.Dequeue();
        Console.WriteLine("Dequeue-ing..."+ elementToremove);
        Console.WriteLine("Head is " + queue.Head);
        elementToremove = queue.Dequeue();
        Console.WriteLine("Dequeue-ing..."+ elementToremove);
        Console.WriteLine("Head is "+queue.Head);
        Console.WriteLine("Occupied cells are " + queue.Size);
        Console.WriteLine("Capacity of queue is " + queue.Capacity);
        queue.Enqueue(1);
        Console.WriteLine("Occupied cells are " + queue.Size);
        Console.WriteLine("Capacity of queue is " + queue.Capacity);

    }
}

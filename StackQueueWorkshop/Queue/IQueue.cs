using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueWorkshop.Queue
{
    public interface IQueue<T>
    {
        int Size { get; }
        int Capacity { get; }
        int Head { get; }

        bool IsEmpty { get; }

        void Enqueue(T element);

        T Dequeue();

        T Peek();

    }
}

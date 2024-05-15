using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackQueueWorkshop.Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private const int defaultSize = 4;
        private T[] items = new T[defaultSize];
        private int capacity = defaultSize;
        private int tail = -1;
        private int count = 0;
        private int head = 0;

        public int Size
        {
            get
            {
                return count;
            }
        }


        public bool IsEmpty
        {
            get
            {
                return count == 0;
            }
        }

        public void Enqueue(T element)
        {
            count++;
            if (count >= capacity)
            {
                Resize(count * 2);
            }
            items[++tail] = element;
        }

        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            T element = items[head];
            head += 1;
            count--;
            if (count == capacity / 2)
            {
                Resize(capacity / 2);
            }
            return element;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return items[head];
        }

        public void Resize(int newCapacity)
        {
            T[] newArrayQueue = new T[items.Length * 2];
            for (int i = 0; i < count; i++)
            {
                newArrayQueue[i] = items[i];
            }
            items = newArrayQueue;
            tail = count - 1;
            capacity = newCapacity;

        }
    }
}

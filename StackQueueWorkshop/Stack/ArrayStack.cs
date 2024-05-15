using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueWorkshop.Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        private const int defaultSize = 4;
        private T[] items = new T[defaultSize];
        private int capacity = defaultSize;
        private int top = -1;
        private int count = 0;

        public int Size
        {
            get
            {
                return top + 1;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return top == -1;
            }
        }

        public void Push(T element)
        {
            if (count == capacity)
            {
                Resize(capacity * 2);
            }
            count++;
            top++;
            items[top] = element;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            T element = items[top];
            top--;
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
                throw new InvalidOperationException("Stack is empty.");
            }
            return items[top];
        }

        private void Resize(int newCapacity)
        {
            T[] newArrayQueue = new T[items.Length * 2];
            for (int i = 0; i < top + 1; i++)
            {
                newArrayQueue[i] = items[i];
            }
            items = newArrayQueue;
            capacity = newCapacity;
        }
    }
}

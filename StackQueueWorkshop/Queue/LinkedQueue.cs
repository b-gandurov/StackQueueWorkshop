using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueWorkshop.Queue
{
    public class LinkedQueue<T> : IQueue<T>
    {
        private Node<T> head, tail;
        private int size;

        public int Size
        {
            get
            {
                return size;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return size == 0;
            }
        }

        public void Enqueue(T element)
        {
            Node<T> newNode = new Node<T>();
            newNode.Data = element;

            if (IsEmpty)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            size++;
        }

        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is Empty.");
            }

            T element = head.Data;
            head = head.Next;
            size--;

            return element;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is Empty.");
            }

            return head.Data;

        }
    }
}

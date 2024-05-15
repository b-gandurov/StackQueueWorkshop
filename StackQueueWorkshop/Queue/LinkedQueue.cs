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
            size++;
            
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                tail = newNode;
            }
        }

        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue not Empty.");
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
                throw new InvalidOperationException("Queue not Empty.");
            }

            return head.Data;

        }
    }
}

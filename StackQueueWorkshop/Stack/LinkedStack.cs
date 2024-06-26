﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueWorkshop.Stack
{
    public class LinkedStack<T> : IStack<T>
    {
        private Node<T> top;
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

        public void Push(T element)
        {
            Node<T> newNode = new Node<T>();
            newNode.Data = element;
            newNode.Next = top;
            top = newNode;
            size++;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T element = top.Data;
            top = top.Next;
            size--;
            return element;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return top.Data;
        }
    }
}

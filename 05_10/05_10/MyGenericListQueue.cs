using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_10
{
    internal class MyGenericListQueue<T> : IMyGenericQueue<T>
    {
        Node? first = null, last = null;
        int N = 0;
        class Node{
            public T item;
            public Node next;

            public Node(T item, MyGenericListQueue<T>.Node next)
            {
                this.item = item;
                this.next = next;
            }

        }
        public int Count => N;

        public bool Empty => first == null;

        public T Dequeue()
        {
            if (N > 0)
            {
                T result;
                result = first.item;
                first = first.next;
                N--;
                if (first == null)
                    last = null;
                return result;
            }
            else
                throw new QueueEmptyException();
        }

        public void Enqueue(T val)
        {
            Node newNode = new Node(val, null);
            N++;
            if (last == null)
            {
                first = last = newNode;
            }
            else
            {
                last.next = newNode;
                last = newNode;
            }
        }
    }
}

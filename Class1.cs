using System;
using System.Collections.Generic;
using System.Text;

namespace labbb1
{
    class SortedLinkedList
    {
        public int Count = 0; 
        public Node first;

        public SortedLinkedList()
        {
            Count = 0;
            first = null;
        }
        public int Length() { return Count; }
        public bool IsEmpty()
        {
            if (Count == 0 || first == null) return true;
            else return false;
        }
        public bool IsFull()
        {
            bool result = false;
            Node tryy = new Node();
            if (tryy == null)
                return result = true;
            else
                return result;

        }
        public void Add(int value)
        {
            Node newnode = new Node(value);
            Node current;
            if (IsFull())
            {
                Console.WriteLine("List overflow\n");
                return;
            }
            if (first == null)
            {
                first = new Node(value, first);
                Count++;
                return;
            }
            
        }

    }
}

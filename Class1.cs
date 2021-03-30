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
            if (value <= first.data)
            {
                Node temp = first;
                first = new Node(value, first);
                first.next = temp;
                Count++;
            }
            else
            {
                current = first;

                while (current.next != null && current.next.data < value)
                    current = current.next;

                newnode.next = current.next;
                current.next = newnode;
                Count++;
            }
        }
        public void PrintList()
        {
            Node temp = first;
            Console.WriteLine("\nYour list: ");
            if (Count == 0) Console.WriteLine("null");
            for (int i = 1; i <= Count; i++)
            {
                if (temp != null)
                {
                    if (i == 1)
                    {
                        if (temp.data != null)
                            Console.Write(temp.data);
                        if (temp.next != null)
                        {
                            Console.Write(" -> ");
                            temp = temp.next;
                        }
                        else { Console.Write(" -> null"); }
                    }
                    if (i > 1 && i < Count)
                    {
                        Console.Write(temp.data);
                        if (temp.next != null)
                        {
                            Console.Write(" -> ");
                            temp = temp.next;
                        }
                        else { Console.Write(" -> null"); }
                    }
                    if (i == Count && i != 1)
                    {
                        Console.Write(temp.data);
                        temp = temp.next;
                    }
                }
                else break;
            }
        }
    }
}

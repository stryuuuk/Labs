using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class LinkedList
    {
        public Node first;
        public int Count { get; private set; }
        public LinkedList()
        {
            first = null;
            Count = 0;
        }
        public LinkedList(Node node)
        {
            node.next = first;
            first = node;
            Count = 0;
        }
        public void PrintList(Node start)
        {
            Node print = start;
            if (print == this.first)
                Console.WriteLine("Your list: ");
            if (print != null)
            {
                Console.Write(print.data + "->");
                PrintList(start.next);
            }
            if (print == null) Console.WriteLine("null");
        }
        public int this[int value]
        {
            get
            {
                int index = 0;
                Node temp = first;
                while (temp.next != null && temp.data != value)
                {
                    index++;
                    temp = temp.next;
                }
                if (temp.data == value)
                    return index;
                else return -1000;

            }
        }
        public void Add(int data)
        {
            if (first == null)
            {
                first = new Node(data);
                Count++;
            }
            else
            {
                Node add = new Node(data, first);
                add.next = first;
                first = add;
                Count++;
            }
        }
    }
}

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
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int d, Node link)
        {
            data = d;
            next = link;
        }
        public Node(int i)
        {
            data = i;
            next = null;
        }
    }
}

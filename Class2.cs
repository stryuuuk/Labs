using System;
using System.Collections.Generic;
using System.Text;

namespace labbb1
{
    class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node()
        {
            next = null;
        }
        public Node(T d, Node<T> link = null)
        {
            data = d;
            next = link;
        }
    }
}

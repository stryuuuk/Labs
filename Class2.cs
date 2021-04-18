using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Node<T>
    {
        public T Data;
        public Node<T> left, right;

        public Node()
        {
            left = right = null;
        }
        public Node(T data)
        {
            Data = data;
            left = right = null;
        }
    }
}

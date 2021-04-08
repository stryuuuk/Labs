using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Node
    {
        public int Data;
        public Node left, right;

        public Node(int data)
        {
            Data = data;
            left = right = null;
        }
    }
}

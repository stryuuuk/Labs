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

    }
}

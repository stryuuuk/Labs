using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class BBST
    {
        public int Count;
        public Node root;
        public BBST()
        {
            Count = 0;
            root = null;
        }
        public int Size { get { return Count; } }
        public bool IsEmpty()
        {
            if (Count == 0) return true;
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
    }
}

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
        private int Height(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = Height(current.left);
                int r = Height(current.right);
                int m = Math.Max(l, r);
                height = m + 1;
            }
            return height;
        }
        public int BalanceF(Node node)
        {
            int l = Height(node.left);
            int r = Height(node.right);
            int factor = l - r;
            return factor;
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

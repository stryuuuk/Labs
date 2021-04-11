using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            BBST tree = new BBST();
            int[] m = new int[] { 5,3,7,2,1};
            for(int i = 0; i < m.Length; i++) { tree.Add(ref tree.root, m[i]); }
            //Node k = tree.Search(ref tree.root, 10);
            tree.PostOrderPrint(tree.root);
        }
    }
}

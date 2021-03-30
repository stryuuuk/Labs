using System;

namespace labbb1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList list = new SortedLinkedList();
            list.Add(0);
            list.Add(2);
            list.Add(-5);
            list.Add(10);
            //SortedLinkedList list1 = new SortedLinkedList();
            list.Add(-3);
            list.Add(15);
            list.Add(5);
            list.Add(1);
            list.Delete(0);
            list.Delete(1);
            list.Search(-3);
            list.PrintList();
            
            
        }
    }
}

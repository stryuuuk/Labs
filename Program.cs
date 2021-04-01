using System;

namespace labbb1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList<int> list = new SortedLinkedList<int>();
            list.Add(0);
            list.Add(2);
            list.Add(-5);
            list.Add(10);
            SortedLinkedList<char> list1 = new SortedLinkedList<char>();
            list1.Add('c');
            list1.Add('d');
            list1.Add('a');
            list1.Add('b');
            SortedLinkedList<string> list2 = new SortedLinkedList<string>();
            list2.Add("baby");
            list2.Add("cat");
            list2.Add("apple");
            list2.Add("abroad");
            list.PrintList();
            list1.PrintList();
            list2.PrintList();


        }
    }
}

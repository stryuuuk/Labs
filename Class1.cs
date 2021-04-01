using System;
using System.Collections.Generic;
using System.Text;

namespace labbb1
{
    class SortedLinkedList<T> where T : IComparable
    {
        public int Count = 0;
        public Node<T> first;

        public SortedLinkedList()
        {
            Count = 0;
            first = null;
        }
        public int Length() { return Count; }
        public bool IsEmpty()
        {
            if (Count == 0 || first == null) return true;
            else return false;
        }
        public bool IsFull()
        {
            bool result = false;
            Node<T> tryy = new Node<T>();
            if (tryy == null)
                return result = true;
            else
                return result;

        }
        public int CompareTo(SortedLinkedList<T> other)
        {
            return this.first.data.CompareTo(other.first.data);
        }
        public void Add(T value)
        {
            Node<T> newnode = new Node<T>(value);
            Node<T> current;
            if (IsFull())
            {
                Console.WriteLine("List overflow\n");
                return;
            }
            if (first == null)
            {
                first = new Node<T>(value, first);
                Count++;
                return;
            }
            if (value.CompareTo(first.data) <= 0)
            {
                Node<T> temp = first;
                first = new Node<T>(value, first);
                first.next = temp;
                Count++;
            }
            else
            {
                current = first;

                while (current.next != null && current.next.data.CompareTo(value) < 0)
                    current = current.next;

                newnode.next = current.next;
                current.next = newnode;
                Count++;
            }
        }
        public void PrintList()
        {
            Node<T> temp = first;
            Console.WriteLine("\nYour list: ");
            if (Count == 0) Console.WriteLine("null");
            for (int i = 1; i <= Count; i++)
            {
                if (temp != null)
                {
                    if (i == 1)
                    {
                        if (temp.data != null)
                            Console.Write(temp.data);
                        if (temp.next != null)
                        {
                            Console.Write(" -> ");
                            temp = temp.next;
                        }
                        else { Console.Write(" -> null"); }
                    }
                    if (i > 1 && i < Count)
                    {
                        Console.Write(temp.data);
                        if (temp.next != null)
                        {
                            Console.Write(" -> ");
                            temp = temp.next;
                        }
                        else { Console.Write(" -> null"); }
                    }
                    if (i == Count && i != 1)
                    {
                        Console.Write(temp.data);
                        temp = temp.next;
                    }
                }
                else break;
            }
        }
        public void Delete(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List underflow");
                return;
            }
            Node<T> last = null;
            Node<T> temp = first;
            while (temp != null && temp.data.CompareTo(value) != 0)
            {
                last = temp;
                temp = temp.next;
            }
            if (last == null && temp != null && temp.data.CompareTo(value) == 0)
            {
                first = first.next;
                temp = null;
                Count--;
            }
            else
            if (last != null && temp != null && temp.data.CompareTo(value) == 0)
            {
                last.next = temp.next;
                temp = null;
                Count--;
            }
            else
            {
                Console.WriteLine("Item was not found and not deleted");
            }
        }
        public bool Search(int value)
        {
            Node<T> temp = first;
            while (temp != null)
            {
                if (temp.data.CompareTo(value) == 0) return true;
                else temp = temp.next;
            }
            return false;

        }
    }
}

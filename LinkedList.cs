using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class LinkedList
    {
        public Node first;
        public int Count { get; private set; }
        public LinkedList()
        {
            first = null;
            Count = 0;
        }
        public LinkedList(Node node)
        {
            node.next = first;
            first = node;
            Count = 0;
        }
        public void PrintList(Node start)
        {
            Node print = start;
            if (print == this.first)
                Console.WriteLine("Your list: ");
            if (print != null)
            {
                Console.Write(print.data + "->");
                PrintList(start.next);
            }
            if (print == null) Console.WriteLine("null");
        }
        public int this[int value]
        {
            get
            {
                int index = 0;
                Node temp = first;
                while (temp.next != null && temp.data != value)
                {
                    index++;
                    temp = temp.next;
                }
                if (temp.data == value)
                    return index;
                else return -1000;

            }
        }
        public void Add(int data)
        {
            if (first == null)
            {
                first = new Node(data);
                Count++;
            }
            else
            {
                Node add = new Node(data, first);
                add.next = first;
                first = add;
                Count++;
            }
        }

        public void Sort()
        {
            Node temp = first;
            int[] save = new int[Count];
            for (int i = 0; i < save.Length; i++)
            {
                save[i] = temp.data;
                temp = temp.next;
            }
            int tempo = save[0];

            for (int i = 0; i < save.Length; i++)
            {
                for (int j = i + 1; j < save.Length; j++)
                {
                    if (save[i] < save[j])
                    {
                        tempo = save[i];

                        save[i] = save[j];

                        save[j] = tempo;
                    }
                }
            }

            for (int i = save.Length - 1; i >= 0; i--)
            {
                if (i == save.Length - 1)
                    this.first = new Node(save[i]);
                else
                {
                    Node t = new Node(save[i]);
                    t.next = this.first;
                    this.first = t;
                }
            }
        }
    }
}

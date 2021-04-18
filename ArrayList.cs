using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class ArrayList<T> where T: IComparable
    {
        public int Max;        
        public int Last;        
        public T[] Array;
        public ArrayList(int max)
        {
            Max = max;
            Last = -1;
            Array = new T[max];
        }
        private bool isEmpty()
        {
            return (Last == -1);
        }

        private bool IsFull()
        {
            return (Last == Max - 1);
        }
        public int Length()
        {
            return Last + 1;
        }
        public T this[int index]
        {
            get
            {
                return Array[index];
            }
        }
        public void Add(T value)
        {
            if (IsFull())
                Extend();
            Array[++Last] = value;
        }
        private T[] Extend()
        {
            T[] temp = new T[Max * 2];
            Max *= 2;
            for (int i = 0; i < Array.Length; i++)
            {
                temp[i] = Array[i];
            }
            return Array = temp;
        }
        public void PrintA()
        {
            T[] temp = Array;
            temp.HeapSort();
            Console.WriteLine("Your List in ascending order: \n");
            for (int i = 0; i < Last + 1; i++)
            {
                Console.Write(temp[i] + " ");
            }
        }
        
    }
}

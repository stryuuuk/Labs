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
            ArrayList<T> temp = this;
            temp.HeapSortMax();
            Console.WriteLine("Your List in ascending order: \n");
            for (int i = 0; i < Last + 1; i++)
            {
                Console.Write(temp[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public void PrintD()
        {
            ArrayList<T> temp = this;
            temp.HeapSortMin();
            Console.WriteLine("Your List in descending order: \n");
            for (int i = 0; i < Last + 1; i++)
            {
                Console.Write(temp[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public void HeapSortMax()
        {
            int n = Length();
            MaxHeap(n);
            for (int i = n-1; i >= 0; i--)
            {
                T temp = this.Array[0];
                this.Array[0] = this.Array[i];
                this.Array[i] = temp;
                HeapifyMax(this.Array, i,0);
            }
        }
        private void MaxHeap(int n)
        {
            for (int i = (n / 2) - 1; i >= 0; i--)
            {
                HeapifyMax(this.Array, n, i);
            }
        }
        private void HeapifyMax(T[] arr,int n,int i)
        {
            int max = i;
            int left = (2 * i)+1;
            int right = (2 * i)+ 2;
            if (left < n && arr[left].CompareTo(arr[max]) > 0)
                max = left;
            if (right < n && arr[right].CompareTo(arr[max]) > 0)
                max = right;
            if (max != i)
            {
                T temp = arr[i];
                arr[i] = arr[max];
                arr[max] = temp;
                HeapifyMax(arr, n, max);
            }
        }
        
    }
}

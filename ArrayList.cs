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
            temp.HeapSort();
            Console.WriteLine("Your List in ascending order: \n");
            for (int i = 0; i < Last + 1; i++)
            {
                Console.Write(temp[i] + " ");
            }
        }
        public void PrintD()
        {
            ArrayList<T> temp = this;
            temp.HeapSort();
            Console.WriteLine("Your List in descending order: \n");
            for (int i = Last; i >= 0; i--)
            {
                Console.Write(temp.Array[i] + " ");
            }
        }
        public T[] HeapSort()
        {
            int n = Length();
            MaxHeap();
            for(int i = n; i >= 1; i--)
            {
                T temp = this.Array[1];
                this.Array[1] = this.Array[i];
                this.Array[i] = temp;
                n--;
                Heapify(this.Array, 1);
            }
            return this.Array;
        }
        private void MaxHeap()
        {
            int n = Length();
            for(int i = n / 2; i >= 1; i--)
            {
                Heapify(this.Array, i);
            }
        }
        private void Heapify(T[] arr,int i)
        {
            int n = Length();
            int max;
            int left = 2 * i;
            int right = 2 * i - 1;
            if (left <= n && arr[left].CompareTo(arr[i]) > 0)
                max = left;
            else
                max = i;
            if (right <= n && arr[right].CompareTo(arr[max]) > 0)
                max = right;
            if (max != i)
            {
                T temp = arr[max];
                arr[max] = arr[i];
                arr[i] = temp;
            }
            Heapify(arr, max);
        }
    }
}

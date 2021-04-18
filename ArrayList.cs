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
        
    }
}

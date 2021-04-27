using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class Vertice<T> where T: IComparable<T>
    {
        private int index;
        public T data;
        public Vertice(T data, int index)
        {
            this.index = index;
            this.data = data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class WeightedGraph<T> where T:IComparable<T>
    {
        private List<Vertice<T>> Vertices;
        private int[,] AdjMatrix;
        private int Size;
        private WeightedGraph(int size)
        {

        }
        public void CreateWeightedGraph(int size)
        {
            WeightedGraph<T> graph = new WeightedGraph<T>(size);
        }
    }
}

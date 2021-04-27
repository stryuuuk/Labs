using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class WeightedGraph
    {
        private List<Vertice> Vertices;
        private Vertice[,] AdjMatrix;
        private int Size;
        private WeightedGraph(int size)
        {
            Size = size;
            AdjMatrix = new Vertice[size, size];
        }
        public void CreateWeightedGraph(int size)
        {
            WeightedGraph<T> graph = new WeightedGraph<T>(size);
        }

    }
}

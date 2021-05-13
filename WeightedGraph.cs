using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class WeightedGraph
    {
        private Edge[,] AdjMatrix;
        private int Size;
        private int EdgeCount = 0;
        private Edge[] edges;
        public WeightedGraph(int size)
        {
            Size = size;
            AdjMatrix = new Edge[size, size];
            edges = new Edge[size * (size - 1 ) / 2];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j != i)
                    {
                        if (AdjMatrix[i, j] == null && AdjMatrix[j, i] == null)
                        {
                            Console.WriteLine($"Write the weight of the edge V{i}-V{j}");
                            AdjMatrix[i, j] = AdjMatrix[j, i] = new Edge(new Vertice(i), new Vertice(j), Convert.ToInt32(Console.ReadLine()));
                            if (AdjMatrix[i, j].Weight != 0)
                            {
                                edges[EdgeCount] = AdjMatrix[i, j];
                                EdgeCount++;
                            }
                        }
                    }
                    else
                        AdjMatrix[i, j] = new Edge(new Vertice(i), new Vertice(j), 0);
                }
            }
        }
        
        
    }
}

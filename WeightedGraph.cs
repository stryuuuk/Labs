using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class WeightedGraph
    {
        private List<Vertice> Vertices;
        private Edge[,] AdjMatrix;
        private int Size;
        public WeightedGraph(int size)
        {
            Size = size;
            AdjMatrix = new Edge[size, size];
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
                        }
                    }
                    else
                        AdjMatrix[i, j] = new Edge(new Vertice(i), new Vertice(j), 0);
                }
            }
        }
        
        public void Print()
        {
            Console.WriteLine("Your graph:");
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write(AdjMatrix[i, j].Weight+" ");
                }
                Console.WriteLine();
            }
        }
        
    }
}

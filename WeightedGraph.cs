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

        public void Print()
        {
            Console.WriteLine("Your graph:");
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write(AdjMatrix[i, j].Weight + " ");
                }
                Console.WriteLine();
            }
        }
        private void Sort(Edge[] e)
        {
            for (int write = 0; write < EdgeCount; write++)
            {
                for (int sort = 0; sort < EdgeCount - 1; sort++)
                {
                    if (e[sort].Weight > e[sort + 1].Weight)
                    {
                        Edge temp = e[sort + 1];
                        e[sort + 1] = e[sort];
                        e[sort] = temp;
                    }
                }
            }
        }
        private bool Find(int[] m, int index)
        {
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == index) return true;
            }
            return false;
        }
        public void Kruskal()
        {
            Sort(edges);
            List<Edge> minspantree = new List<Edge>();
            int[] used = new int[EdgeCount * 2];
            int count = 0;
            for (int i = 0; i < EdgeCount; i++)
            {
                if (!(Find(used, edges[i].First.index) == true && Find(used, edges[i].Second.index) == true))
                {
                    minspantree.Add(edges[i]);
                    used[count] = edges[i].First.index;
                    count++;
                    used[count] = edges[i].Second.index;
                    count++;
                }
            }
            int sum = 0;
            Console.WriteLine("Minimum spanning tree: ");
            for (int i = 0; i < minspantree.Count; i++)
            {
                Console.Write($"{minspantree[i].Weight}");
                sum += minspantree[i].Weight;
                if (i != minspantree.Count - 1)
                    Console.Write(" + ");
                else
                    Console.Write(" = " + sum);
            }
            Console.WriteLine();
            for (int i = 0; i < minspantree.Count; i++)
            {
                Console.Write($"V{minspantree[i].First.index}-V{minspantree[i].Second.index}");
                if (i != minspantree.Count - 1)
                    Console.Write(" + ");
                else
                    Console.Write(" = " + sum);
            }
        }
        
    }
}

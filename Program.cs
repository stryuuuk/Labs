using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightedGraph graph = new WeightedGraph(5);
            graph.Print();
            //graph.Kruskal();
            graph.Dijkstra(0, 4);
        }
    }
}

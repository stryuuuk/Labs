using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class Edge
    {
        public Vertice First { private set; get; }
        public Vertice Second { private set; get; }
        public int Weight { private set; get; }
        public Edge(Vertice first, Vertice second,int w)
        {
            First = first;
            Second = second;
            Weight = w;
        }
    }
}

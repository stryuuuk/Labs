using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList<int> list = new ArrayList<int>(5);
            list.Add(2);
            list.Add(3);
            list.Add(1);
            list.Add(5);
            list.Add(-1);
            list.Add(0);
            list.PrintA();
            list.PrintD();
        }
    }
}

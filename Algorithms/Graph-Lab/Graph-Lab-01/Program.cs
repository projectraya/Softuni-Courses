using System.Collections.Generic;
using System;
using System.Linq;
namespace Graph_Lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(4);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            Console.Write("Following is Breadth First " + 
                "Traversal(starting from " +
                "vertex 2)\n");

            graph.BFS(2);
        }
    }

    public class Graph
    {
        public int VerticesCount;   
        public LinkedList<int>[] Adjacents;


        public Graph(int _verticesCount)
        {
            Adjacents = new LinkedList<int>[_verticesCount];
            for (int i = 0; i < Adjacents.Length; i++)
            {
                Adjacents[i] = new LinkedList<int>();
            }
            VerticesCount = _verticesCount;
        }

        public void AddEdge(int first, int second)
        {
            Adjacents[first].AddLast(second);
        }

        public void BFS(int vertex)
        {
            bool[] visitedVertices = new bool[VerticesCount];
            LinkedList<int> queue = new LinkedList<int>();

            visitedVertices[vertex] = true;
            queue.AddLast(vertex);

            while (queue.Any())
            {
                vertex = queue.First();
                Console.Write(vertex + " ");
                queue.RemoveFirst();
                LinkedList<int> list = Adjacents[vertex];

                foreach (var adjacent in list)
                {
                    if (!visitedVertices[adjacent])
                    {
                        visitedVertices[adjacent] = true;
                        queue.AddLast(adjacent);
                    }
                }
            }
        }
    }
}

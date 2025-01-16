using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Sandbox
{
    public class Graph
    {
        Dictionary<int, List<int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<int>();
            }
        }

        public void AddEdge(int source, int destination, bool isUndirected = true)
        {
            if (!adjacencyList.ContainsKey(source))
            {
                AddVertex(source);
            }
            if (!adjacencyList.ContainsKey(destination))
            {
                AddVertex(destination);
            }

        }
        
        public Dictionary<int, List<int>> GetAdjacencyList()
        {
            return adjacencyList;
        }
        
    }

    public class GraphTraversal
    {
        public static void BFS(Graph graph, int startVertex)
        {
            var visited = new HashSet<int>();
            var queue = new Queue<int>();

            queue.Enqueue(startVertex);
            visited.Add(startVertex);

            Console.WriteLine("BFS Traversal:");

            while(queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                Console.Write(vertex + " ");

                foreach(int neighbor in graph.GetAdjacencyList()[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }
    }
}

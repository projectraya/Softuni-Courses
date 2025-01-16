namespace Graph_Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a graph
            Graph graph = new Graph();

            // Add edges
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 5);
            graph.AddEdge(2, 6);

            // Perform BFS and DFS
            GraphTraversal.BFS(graph, 0); // Start BFS from vertex 0
            Console.Write(graph);
        }
    }
}

using System;

class DijkstraAlgorithm
{
    static int MinDistance(int[] dist, bool[] visited, int vertices)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < vertices; v++)
        {
            if (!visited[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }
        return minIndex;
    }

    static void PrintPath(int[] parent, int j)
    {
        if (parent[j] == -1)
        {
            Console.Write(j);
            return;
        }
        PrintPath(parent, parent[j]);
        Console.Write(" -> " + j);
    }

    static void Dijkstra(int[,] graph, int source, int vertices)
    {
        int[] dist = new int[vertices];     // Stores shortest distances
        bool[] visited = new bool[vertices]; // Keeps track of visited nodes
        int[] parent = new int[vertices];    // Stores path

        for (int i = 0; i < vertices; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
            parent[i] = -1;
        }

        dist[source] = 0;

        for (int count = 0; count < vertices - 1; count++)
        {
            int u = MinDistance(dist, visited, vertices);
            visited[u] = true;

            for (int v = 0; v < vertices; v++)
            {
                if (!visited[v] && graph[u, v] != 0 &&
                    dist[u] != int.MaxValue &&
                    dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                    parent[v] = u;
                }
            }
        }

        // Output
        Console.WriteLine("Node\tDistance\tPath");
        for (int i = 0; i < vertices; i++)
        {
            Console.Write(i + "\t" + dist[i] + "\t\t");
            PrintPath(parent, i);
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int vertices = 5;

        // Adjacency matrix for a 5-node graph
        // 0 means no direct edge
        int[,] graph = {
            { 0,  10,  0,  30, 100 },
            { 10,  0, 50,  0,   0 },
            { 0,  50,  0, 20,  10 },
            { 30,  0, 20,  0,  60 },
            {100,  0, 10, 60,   0 }
        };

        Console.WriteLine("Dijkstra’s Algorithm - Shortest Paths from Node 0:");
        Dijkstra(graph, 0, vertices);
    }
}


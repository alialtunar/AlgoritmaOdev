using System;
using System.Collections.Generic;

public class Graph
{
    private int V;
    private List<int>[] adj;

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];

        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }

    public void ZhuTakaoka(int s)
    {
        int[] dist = new int[V];
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
        }

        dist[s] = 0;

        for (int i = 0; i < V - 1; i++)
        {
            int u = MinDistance(dist, visited);
            visited[u] = true;

            for (int j = 0; j < adj[u].Count; j++)
            {
                int v = adj[u][j];

                if (!visited[v] && adj[u][j] != 0 && dist[u] != int.MaxValue && dist[u] + adj[u][j] < dist[v])
                {
                    dist[v] = dist[u] + adj[u][j];
                }
            }
        }

        PrintSolution(dist);
    }

    private int MinDistance(int[] dist, bool[] visited)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int i = 0; i < V; i++)
        {
            if (visited[i] == false && dist[i] <= min)
            {
                min = dist[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

    private void PrintSolution(int[] dist)
    {
        Console.WriteLine("Kaynaktan Köşe Mesafesi");
        for (int i = 0; i < V; i++)
        {
            Console.WriteLine(i + " \t\t " + dist[i]);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Graph g = new Graph(5);

        g.AddEdge(0, 1, 10);
        g.AddEdge(0, 4, 5);
        g.AddEdge(1, 2, 1);
        g.AddEdge(1, 4, 2);
        g.AddEdge(2, 3, 4);
        g.AddEdge(3, 2, 6);
        g.AddEdge(4, 1, 3);
        g.AddEdge(4, 2, 9);
        g.AddEdge(4, 3, 2);

        g.ZhuTakaoka(0);
    }
}

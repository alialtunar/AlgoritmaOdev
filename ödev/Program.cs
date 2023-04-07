using System;
using System.Collections.Generic;

public class DijkstraAlgorithm
{
    private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int vertices)
    {
        int min = int.MaxValue, minIndex = 0;

        for (int v = 0; v < vertices; ++v)
        {
            if (shortestPathTreeSet[v] == false && distance[v] <= min)
            {
                min = distance[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    private static void Print(int[] distance, int vertices)
    {
        Console.WriteLine("Köşe \\ t Kaynaktan Uzaklık");
        for (int i = 0; i < vertices; ++i)
        {
            Console.WriteLine("{0} \t\t {1}", i, distance[i]);
        }
    }

    public static void Dijkstra(int[,] graph, int source, int vertices)
    {
        int[] distance = new int[vertices];
        bool[] shortestPathTreeSet = new bool[vertices];

        for (int i = 0; i < vertices; ++i)
        {
            distance[i] = int.MaxValue;
            shortestPathTreeSet[i] = false;
        }

        distance[source] = 0;

        for (int count = 0; count < vertices - 1; ++count)
        {
            int u = MinimumDistance(distance, shortestPathTreeSet, vertices);
            shortestPathTreeSet[u] = true;

            for (int v = 0; v < vertices; ++v)
            {
                if (!shortestPathTreeSet[v] && graph[u, v] != 0 && distance[u] != int.MaxValue &&
                    distance[u] + graph[u, v] < distance[v])
                {
                    distance[v] = distance[u] + graph[u, v];
                }
            }
        }

        Print(distance, vertices);
    }

    public static void Main()
    {
        int[,] graph = { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                         { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                         { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                         { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                         { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                         { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                         { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                         { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                         { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };

        Dijkstra(graph, 0, 9);
    }
}

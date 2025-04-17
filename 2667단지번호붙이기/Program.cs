using System;
using System.Collections.Generic;

class Program
{
    static int n;
    static int[,] house;
    static bool[,] visited;
    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        house = new int[n, n];
        visited = new bool[n, n];

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < n; j++)
                house[i, j] = line[j] - '0';
        }

        List<int> complexSizes = new List<int>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (house[i, j] == 1 && !visited[i, j])
                {
                    complexSizes.Add(BFS(i, j));
                }
            }
        }

        complexSizes.Sort();
        Console.WriteLine(complexSizes.Count);
        foreach (int size in complexSizes)
            Console.WriteLine(size);
    }

    static int BFS(int x, int y)
    {
        int count = 1;
        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((x, y));
        visited[x, y] = true;

        while (q.Count > 0)
        {
            var (cx, cy) = q.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int nx = cx + dx[i];
                int ny = cy + dy[i];

                if (nx >= 0 && ny >= 0 && nx < n && ny < n)
                {
                    if (house[nx, ny] == 1 && !visited[nx, ny])
                    {
                        visited[nx, ny] = true;
                        q.Enqueue((nx, ny));
                        count++;
                    }
                }
            }
        }

        return count;
    }
}

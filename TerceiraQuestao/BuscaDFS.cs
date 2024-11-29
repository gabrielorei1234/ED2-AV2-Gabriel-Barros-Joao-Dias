using System;
using System.Collections.Generic;

public class BuscaDFS
{
    const int N = 10; // Tamanho do labirinto

    static int[,] maze = {
        {1, 1, 1, 1, 1, 1, 1, 0, 1, 1},
        {1, 0, 0, 0, 0, 0, 1, 1, 1, 0},
        {1, 1, 1, 1, 0, 1, 0, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 1, 1, 0, 1},
        {1, 0, 1, 1, 1, 1, 1, 0, 0, 1},
        {1, 1, 1, 0, 1, 0, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 0, 0, 1, 1},
        {1, 0, 1, 1, 1, 0, 1, 0, 1, 1},
        {1, 1, 1, 0, 1, 1, 1, 1, 1, 0},
        {1, 1, 1, 0, 1, 1, 1, 1, 1, 1}
    };

    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };

    public bool IsValid(int x, int y, bool[,] visited)
    {
        return x >= 0 && x < N && y >= 0 && y < N && maze[x, y] == 1 && !visited[x, y];
    }

    public bool DFS(int x, int y, int targetX, int targetY, ref List<(int, int)> path, bool[,] visited)
    {
        if (x == targetX && y == targetY)
        {
            path.Add((x, y));
            return true;
        }

        visited[x, y] = true;

        for (int i = 0; i < 4; i++)
        {
            int newX = x + dx[i];
            int newY = y + dy[i];

            if (IsValid(newX, newY, visited))
            {
                path.Add((x, y));
                if (DFS(newX, newY, targetX, targetY, ref path, visited))
                {
                    return true;
                }
                path.RemoveAt(path.Count - 1);
            }
        }

        return false;
    }

    public void IniciarBusca()
    {
        int startX = 0, startY = 0; // Início
        int targetX = 8, targetY = 9; // Destino

        if (maze[startX, startY] == 0 || maze[targetX, targetY] == 0)
        {
            Console.WriteLine("Ponto de início ou fim bloqueado!");
            return;
        }

        List<(int, int)> path = new List<(int, int)>();
        bool[,] visited = new bool[N, N];

        if (DFS(startX, startY, targetX, targetY, ref path, visited))
        {
            Console.WriteLine("Caminho encontrado:");
            foreach (var p in path)
            {
                Console.Write($"({p.Item1}, {p.Item2}) ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Caminho não encontrado.");
        }
    }
}

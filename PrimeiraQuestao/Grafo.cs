using System;
using System.Collections.Generic;

class Grafo
{
    private List<int>[] adj;

    public Grafo(int numVertices)
    {
        adj = new List<int>[numVertices];
        for (int i = 0; i < numVertices; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AdicionarAresta(int v1, int v2)
    {
        adj[v1].Add(v2);
        adj[v2].Add(v1);
    }

    public void Colorir()
    {
        int numVertices = adj.Length;
        int[] cores = new int[numVertices];
        bool[] coresDisponiveis = new bool[numVertices];

        for (int i = 0; i < numVertices; i++)
        {
            cores[i] = 0;
        }

        cores[0] = 1;

        for (int u = 1; u < numVertices; u++)
        {
            for (int i = 0; i < numVertices; i++)
            {
                coresDisponiveis[i] = true;
            }

            foreach (int vizinho in adj[u])
            {
                if (cores[vizinho] != 0)
                {
                    coresDisponiveis[cores[vizinho] - 1] = false;
                }
            }

            for (int cor = 0; cor < numVertices; cor++)
            {
                if (coresDisponiveis[cor])
                {
                    cores[u] = cor + 1;
                    break;
                }
            }
        }

        Console.WriteLine("Cores dos vértices:");
        for (int i = 0; i < numVertices; i++)
        {
            Console.WriteLine($"Vértice {i}: Cor {cores[i]}");
        }
    }
}
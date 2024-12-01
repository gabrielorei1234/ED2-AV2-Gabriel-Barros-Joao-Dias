using System;
using System.Collections.Generic;

namespace ED2_AV2_Gabriel_Barros_Joao_Dias.TerceiraQuestao
{
    public class TerceiraQuestao
    {
        public static void Executar()
        {
            Labirinto labirinto = new Labirinto();
            Dictionary<int, List<int>> grafo = labirinto.GetGrafo();

            List<int> path = new List<int>();
            HashSet<int> visited = new HashSet<int>();

            int entrada1 = 1;
            int entrada2 = 4;
            int saida = 50;

            // Tente encontrar o caminho a partir da primeira entrada
            if (DFS(grafo, entrada1, saida, ref path, visited))
            {
                Console.WriteLine("Caminho encontrado a partir da entrada 1:");
                Console.WriteLine(string.Join(" - ", path));
                return;
            }

            // Se não encontrar, tente a partir da segunda entrada
            path.Clear();
            visited.Clear();
            if (DFS(grafo, entrada2, saida, ref path, visited))
            {
                Console.WriteLine("Caminho encontrado a partir da entrada 2:");
                Console.WriteLine(string.Join(" - ", path));
            }
            else
            {
                Console.WriteLine("Caminho não encontrado.");
            }
        }

        private static bool DFS(Dictionary<int, List<int>> grafo, int vertice, int target, ref List<int> path, HashSet<int> visited)
        {
            if (vertice == target)
            {
                path.Add(vertice);
                return true;
            }

            visited.Add(vertice);

            foreach (int adjacente in grafo[vertice])
            {
                if (!visited.Contains(adjacente))
                {
                    path.Add(vertice);
                    if (DFS(grafo, adjacente, target, ref path, visited))
                    {
                        return true;
                    }
                    path.RemoveAt(path.Count - 1);
                }
            }

            return false;
        }
    }
}
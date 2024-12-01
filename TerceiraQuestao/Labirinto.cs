using System;
using System.Collections.Generic;

namespace ED2_AV2_Gabriel_Barros_Joao_Dias.TerceiraQuestao
{
    public class Labirinto
    {
        // Representação do grafo usando um dicionário de listas de adjacência
        private Dictionary<int, List<int>> grafo = new Dictionary<int, List<int>>
        {
            { 1, new List<int> { 6 } },
            { 2, new List<int> { 3 } },
            { 3, new List<int> () },
            { 4, new List<int> { 5, 9 } },
            { 5, new List<int> { 19 } },
            { 6, new List<int> { 7 } },
            { 7, new List<int> { 2, 8 } },
            { 8, new List<int> { 15 } },
            { 9, new List<int> { 29 } },
            { 10, new List<int> { 16 } },
            { 11, new List<int> () },
            { 12, new List<int> { 11, 13 } },
            { 13, new List<int> () },
            { 14, new List<int> () },
            { 15, new List<int> { 14, 21 } },
            { 16, new List<int> { 17 } },
            { 17, new List<int> { 12 } },
            { 18, new List<int> { 24 } },
            { 19, new List<int> { 18, 20 } },
            { 20, new List<int> { 27 } },
            { 21, new List<int> () },
            { 22, new List<int> () },
            { 23, new List<int> { 22 } },
            { 24, new List<int> { 25 } },
            { 25, new List<int> { 34 } },
            { 26, new List<int> { 40 } },
            { 27, new List<int> { 26, 28 } },
            { 28, new List<int> { 46 } },
            { 29, new List<int> { 30 } },
            { 30, new List<int> { 51 } },
            { 31, new List<int> { 32 } },
            { 32, new List<int> { 23 } },
            { 33, new List<int> { 38 } },
            { 34, new List<int> { 33 } },
            { 35, new List<int> () },
            { 36, new List<int> () },
            { 37, new List<int> { 41 } },
            { 38, new List<int> { 37 } },
            { 39, new List<int> { 43 } },
            { 40, new List<int> { 39 } },
            { 41, new List<int> { 42 } },
            { 42, new List<int> () },
            { 43, new List<int> { 44 } },
            { 44, new List<int> { 50 } },
            { 45, new List<int> { 35 } },
            { 46, new List<int> { 45 } },
            { 47, new List<int> { 31, 48 } },
            { 48, new List<int> { 54 } },
            { 49, new List<int> { 50 } },
            { 50, new List<int> { 63 } },
            { 51, new List<int> { 47, 59 } },
            { 52, new List<int> { 58 } },
            { 53, new List<int> { 60 } },
            { 54, new List<int> { 53 } },
            { 55, new List<int> { 56 } },
            { 56, new List<int> () },
            { 57, new List<int> { 36 } },
            { 58, new List<int> { 57 } },
            { 59, new List<int> () },
            { 60, new List<int> { 61 } },
            { 61, new List<int> { 55 } },
            { 62, new List<int> () },
            { 63, new List<int> { 62 } }
        };

        public Dictionary<int, List<int>> GetGrafo()
        {
            return grafo;
        }
    }
}
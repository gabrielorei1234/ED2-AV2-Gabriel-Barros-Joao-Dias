namespace ED2_AV2_Gabriel_Barros_Joao_Dias.SegundaQuestao
{
    using System;

    public class SegundaQuestao
    {
        public static void Executar()
        {
            try
            {
                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "matriz.csv");
                GrafoPonderado grafo = new GrafoPonderado(caminhoArquivo);

                Console.WriteLine("\nMatriz de adjacências lida:");
                grafo.ExibirMatriz();

                Console.WriteLine("\nÁrvore Geradora de Custo Mínimo:");
                CalcularArvoreGeradoraMinima(grafo.Matriz);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar a matriz de adjacências: {ex.Message}");
            }
        }

        private static void CalcularArvoreGeradoraMinima(int[,] grafo)
        {
            int n = grafo.GetLength(0);
            bool[] visitado = new bool[n];
            int[] pai = new int[n];
            int[] chave = new int[n];

            for (int i = 0; i < n; i++)
            {
                chave[i] = int.MaxValue;
                pai[i] = -1;
            }

            chave[0] = 0;

            for (int cont = 0; cont < n - 1; cont++)
            {
                int u = ObterVerticeComMenorChave(chave, visitado);
                visitado[u] = true;

                for (int v = 0; v < n; v++)
                {
                    if (grafo[u, v] != 0 && !visitado[v] && grafo[u, v] < chave[v])
                    {
                        chave[v] = grafo[u, v];
                        pai[v] = u;
                    }
                }
            }

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"{pai[i]} - {i} (peso: {grafo[i, pai[i]]})");
            }
        }

        private static int ObterVerticeComMenorChave(int[] chave, bool[] visitado)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int i = 0; i < chave.Length; i++)
            {
                if (!visitado[i] && chave[i] < min)
                {
                    min = chave[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}
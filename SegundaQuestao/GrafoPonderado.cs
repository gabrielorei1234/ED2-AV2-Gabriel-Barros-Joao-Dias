namespace ED2_AV2_Gabriel_Barros_Joao_Dias.SegundaQuestao
{
    using System;
    using System.IO;

    public class GrafoPonderado
    {
        public int[,] Matriz { get; private set; }

        public GrafoPonderado(string caminhoArquivo)
        {
            Matriz = LerMatrizDeArquivo(caminhoArquivo);
        }

        private int[,] LerMatrizDeArquivo(string caminhoArquivo)
        {
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            int n = linhas.Length;
            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = linhas[i].Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (valores.Length != n)
                {
                    throw new FormatException("A matriz de adjacências deve ser quadrada e não direcional.");
                }

                for (int j = 0; j < valores.Length; j++)
                {
                    if (!int.TryParse(valores[j], out matriz[i, j]))
                    {
                        throw new FormatException($"Valor inválido na linha {i + 1}, coluna {j + 1}.");
                    }
                }
            }
            return matriz;
        }

        public void ExibirMatriz()
        {
            int n = Matriz.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{Matriz[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
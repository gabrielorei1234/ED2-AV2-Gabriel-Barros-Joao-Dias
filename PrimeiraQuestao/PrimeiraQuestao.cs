namespace ED2_AV2_Gabriel_Barros_Joao_Dias.PrimeiraQuestao;

public class PrimeiraQuestao
{
    public static void Executar()
    {
        int numVertices = 16;
        Grafo grafo = new Grafo(numVertices);

        grafo.AdicionarAresta(8, 0);
        grafo.AdicionarAresta(8, 9);
        grafo.AdicionarAresta(8, 10);
        grafo.AdicionarAresta(9, 4);
        grafo.AdicionarAresta(9, 11);
        grafo.AdicionarAresta(10, 3);
        grafo.AdicionarAresta(10, 11);
        grafo.AdicionarAresta(11, 7);
        grafo.AdicionarAresta(12, 1);
        grafo.AdicionarAresta(12, 13);
        grafo.AdicionarAresta(12, 14);
        grafo.AdicionarAresta(13, 5);
        grafo.AdicionarAresta(13, 15);
        grafo.AdicionarAresta(14, 2);
        grafo.AdicionarAresta(14, 15);
        grafo.AdicionarAresta(15, 6);
        grafo.AdicionarAresta(0, 4);
        grafo.AdicionarAresta(0, 3);
        grafo.AdicionarAresta(0, 1);
        grafo.AdicionarAresta(1, 5);
        grafo.AdicionarAresta(1, 2);
        grafo.AdicionarAresta(2, 6);
        grafo.AdicionarAresta(2, 3);
        grafo.AdicionarAresta(3, 7);
        grafo.AdicionarAresta(4, 7);
        grafo.AdicionarAresta(4, 5);
        grafo.AdicionarAresta(5, 6);
        grafo.AdicionarAresta(6, 7);
        grafo.Colorir();
    }
}
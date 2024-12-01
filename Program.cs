using ED2_AV2_Gabriel_Barros_Joao_Dias.PrimeiraQuestao;
using ED2_AV2_Gabriel_Barros_Joao_Dias.SegundaQuestao;
using ED2_AV2_Gabriel_Barros_Joao_Dias.TerceiraQuestao;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Questão 1 - Coloração de Grafos");
            Console.WriteLine("2. Questão 2 - Árvore Geradora de Custo Mínimo");
            Console.WriteLine("3. Questão 3 - Algoritmo de Busca em Profundidade");
            Console.WriteLine("4. Sair");
            Console.Write("Selecione uma opção (1-4): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Você selecionou a Opção 1 - Coloração de Grafos");
                    PrimeiraQuestao.Executar();
                    break;
                case "2":
                    Console.WriteLine("Você selecionou a Opção 2 - Árvore Geradora de Custo Mínimo");
                    SegundaQuestao.Executar();
                    break;
                case "3":
                    Console.WriteLine("Você selecionou a Opção 3 - Algoritmo de Busca em Profundidade");
                    TerceiraQuestao.Executar();
                    break;
                case "4":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
class Program
{
    static void Main()
    {
        var busca = new BuscaDFS();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Questão 1");
            Console.WriteLine("2. Questão 2");
            Console.WriteLine("3. Questão 3");
            Console.WriteLine("4. Sair");
            Console.Write("Selecione uma opção (1-4): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Você selecionou a Opção 1");
                    break;
                case "2":
                    Console.WriteLine("Você selecionou a Opção 2");
                    break;
                case "3":
                    Console.WriteLine("Você selecionou a Opção 3");
                    busca.IniciarBusca();
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

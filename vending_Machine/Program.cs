using System;

class Program
{
    static void Main(string[] args)
    {
        GerenciadorVendas maquina = new GerenciadorVendas();

        maquina.AdicionarProduto(new Produto("Coca-Cola", 5.00, 10));
        maquina.AdicionarProduto(new Produto("Pepsi", 4.50, 8));
        maquina.AdicionarProduto(new Produto("Guaraná", 4.00, 5));

        while (true)
        {
            Console.WriteLine("\n--- VENDING MACHINE ---");
            Console.WriteLine("1. Exibir Estoque");
            Console.WriteLine("2. Comprar Produto");
            Console.WriteLine("3. Exibir Total de Vendas");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    maquina.ExibirEstoque();
                    break;

                case "2":
                    Console.Write("Digite o nome do produto: ");
                    string nomeProduto =  Console.ReadLine();

                    

                    Console.Write("Digite o valor inserido: ");
                    double valor = double.Parse(Console.ReadLine());

                    maquina.VenderProduto(nomeProduto, valor);
                    
                    break;

                case "3":
                    maquina.ExibirTotalVendas();
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
using System;
using System.Collections.Generic;

public class GerenciadorVendas
{
    private List<Produto> produtos;
    public double TotalVendas { get; private set; }

    public GerenciadorVendas()
    {
        produtos = new List<Produto>();
        TotalVendas = 0;
    }

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public void ExibirEstoque()
    {
        Console.WriteLine("Estoque da Máquina:");
        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {produtos[i].Nome} - R${produtos[i].Preco:F2} - Quantidade: {produtos[i].Quantidade}");
        }
    }

    // Método para vender um produto
    public void VenderProduto(string nomeProduto, double valorInserido)
    {
        Produto produto = null;
        foreach (var p in produtos)
        {
            if (p.Nome.ToLower() == nomeProduto.ToLower())
            {
                produto = p;
                break;
            }
        }

        if (produto == null)
        {
            Console.WriteLine("Produto não encontrado!");
            return;
        }

        if (produto.Quantidade == 0)
        {
            Console.WriteLine("Produto esgotado!");
            return;
        }

       
        SolicitarValorAdicional(produto,valorInserido);

        produto.Quantidade--;
        TotalVendas += produto.Preco;

        if (valorInserido > produto.Preco)
        {
            double troco = valorInserido - produto.Preco;
            Console.WriteLine($"Venda realizada! Troco: R${troco:F2}");
        }
        else
        {
            Console.WriteLine("Venda realizada!");
        }
    }

  private void SolicitarValorAdicional(Produto produto,  double valorInserido)
{
    while (valorInserido < produto.Preco)
    {
        double valorFaltante = produto.Preco - valorInserido;
        Console.WriteLine($"Valor insuficiente. Faltam R${valorFaltante:F2}");
        Console.Write("💰 Digite o valor adicional: ");

        if (double.TryParse(Console.ReadLine(), out double valorAdicional))
        {
            valorInserido += valorAdicional;
        }
        else
        {
            Console.WriteLine("⚠️ Entrada inválida! Por favor, insira um número.");
        }
    }
}


    public void ExibirTotalVendas()
    {
        Console.WriteLine($"Total de vendas: R${TotalVendas:F2}");
    }

    public void ExibirTotalEstoque()
    {
        Console.WriteLine("\nEstoque Atual:");

        foreach (var produto in produtos)
        {
            Console.WriteLine($" Produto: {produto.Nome}, Preço: R${produto.Preco:F2}, Quantidade: {produto.Quantidade}");
        }
    }
}
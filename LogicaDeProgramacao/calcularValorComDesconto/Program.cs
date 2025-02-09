using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor: ");
        string valor = Console.ReadLine();

        Console.Write("Digite o desconto : ");
        string desconto = Console.ReadLine();

        string resultado = CalcularValorComDescontoFormatado(valor, desconto);
        Console.WriteLine("Valor com desconto: " + resultado);
    }

    static string CalcularValorComDescontoFormatado(string valor, string desconto)
    {
        valor = valor.Replace("R$ ", "").Replace(".", "").Replace(",", "");
        desconto = desconto.Replace("%", "");

        int v = int.Parse(valor);
        int d = int.Parse(desconto);

        int resultado = v * (100 - d) / 100;

        string resultadoFormatado = "R$ " + (resultado / 100) + "." + (resultado % 100).ToString("00");

        return resultadoFormatado;
    }
}

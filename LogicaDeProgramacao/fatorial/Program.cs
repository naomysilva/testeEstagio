using System;
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Digite um número: ");
        int fatorial = 1;
        int numero = int.Parse(Console.ReadLine());

        for (int i = 2; i <= numero; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine($"O fatorial de {numero}: {fatorial}");
    }
}
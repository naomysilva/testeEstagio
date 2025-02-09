using System;

class Program
{
    static void Main()
    {
        int acumulador = 0; 
        int numero; 

        do
        {
            Console.Write("Digite um número (ou 0 para sair): ");
            string input = Console.ReadLine();
            numero = int.Parse(input); 

            if (numero % 2 != 0 && numero != 0) 
            {
                acumulador++;
            }
        }
        while (numero != 0); 

        Console.WriteLine($"Quantidade de números ímpares digitados: {acumulador}");
    }
}
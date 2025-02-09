using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine().ToLower();

        int total = frase.Count(c => "aeiou".Contains(c));

        Console.WriteLine($"O número total de vogais é: {total}");
        Console.ReadLine();
    }
}

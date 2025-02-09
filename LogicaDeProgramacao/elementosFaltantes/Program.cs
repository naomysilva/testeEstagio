using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] vetor1 = new int[] { 1, 2 };
        int[] vetor2 = new int[] { 1, 2, 5, 3, 4, 5 };

        List<int> elementosFaltantes = ObterElementosFaltantes(vetor1, vetor2);

        Console.WriteLine("Elementos faltantes:");
        foreach (int elemento in elementosFaltantes)
        {
            Console.WriteLine(elemento);
        }
    }

    static List<int> ObterElementosFaltantes(int[] v1, int[] v2)
    {
        List<int> elementosFaltantes = new List<int>();

        foreach (int num in v1)
        {
            if (Array.IndexOf(v2, num) == -1 && !elementosFaltantes.Contains(num))
            {
                elementosFaltantes.Add(num);
            }
        }

        foreach (int num in v2)
        {
            if (Array.IndexOf(v1, num) == -1 && !elementosFaltantes.Contains(num))
            {
                elementosFaltantes.Add(num);
            }
        }

        return elementosFaltantes;
    }
}

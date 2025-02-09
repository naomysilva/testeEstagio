using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] array1 = new int[5] { 1, 3, 7, 12, 8 };
        List<int> novoArrayPares = new List<int>(); 

        for (int i = 0; i < array1.Length; i++) 
        {
            if (array1[i] % 2 == 0) 
            {
                novoArrayPares.Add(array1[i]);
            }
        }

        Console.WriteLine("Números pares:");
        foreach (int num in novoArrayPares)
        {
            Console.Write(num + " ");
        }
    }
}

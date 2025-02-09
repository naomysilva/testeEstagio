using System;

class Program
{
    static void Main()
    {
        string[] nomes = { "Naomy santos", "Jorge Santos", "Naomy Costa" };
        Console.Write("Digite o nome que Deseja buscar: ");
        string nomeBuscado = Console.ReadLine().ToLower(); ;

        foreach (string nome in nomes)
        {
            if (nome.ToLower().Contains(nomeBuscado.ToLower()))
            {
                Console.WriteLine(nome);
            }
        }
    }
}

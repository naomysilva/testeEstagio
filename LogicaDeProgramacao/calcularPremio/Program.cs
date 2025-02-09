using System;

class Program
{
    static void Main()
    {
        CalculoPremio calculoPremio = new CalculoPremio();

        Premio premio1 = new Premio(100, "vip", null);
        Premio premio2 = new Premio(100, "basic", 3);

        calculoPremio.AdicionarPremio(premio1);
        calculoPremio.AdicionarPremio(premio2);

        Console.WriteLine("Prêmio 1: " + calculoPremio.CalcularPremio(premio1)); // 120.00
        Console.WriteLine("Prêmio 2: " + calculoPremio.CalcularPremio(premio2)); // 300.00
    }
}
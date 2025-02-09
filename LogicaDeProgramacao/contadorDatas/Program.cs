using System;

public class Program
{
    public static int CalcularDiferencaData(string dataInicial, string dataFinal)
    {
        int diaInicial = int.Parse(dataInicial.Substring(0, 2));
        int mesInicial = int.Parse(dataInicial.Substring(2, 2));
        int anoInicial = int.Parse(dataInicial.Substring(4, 4));

        int diaFinal = int.Parse(dataFinal.Substring(0, 2));
        int mesFinal = int.Parse(dataFinal.Substring(2, 2));
        int anoFinal = int.Parse(dataFinal.Substring(4, 4));

        int diferenca = 0;

        while (anoInicial != anoFinal || mesInicial != mesFinal || diaInicial != diaFinal)
        {
            diaInicial++;
            if (diaInicial > DiasNoMes(mesInicial, anoInicial))
            {
                diaInicial = 1;
                mesInicial++;
                if (mesInicial > 12)
                {
                    mesInicial = 1;
                    anoInicial++;
                }
            }
            diferenca++;
        }

        return diferenca;
    }

    private static int DiasNoMes(int mes, int ano)
    {
        if (mes == 2)
        {
            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
                return 29;
            else
                return 28;
        }
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
        {
            return 30;
        }
        else
        {
            return 31;
        }
    }

    public static void Main()
    {
        int diferenca = CalcularDiferencaData("10122020", "25122020");
        Console.WriteLine(diferenca);
    }
}
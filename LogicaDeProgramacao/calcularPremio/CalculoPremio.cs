using System;
using System.Collections.Generic;

class CalculoPremio
{
    private List<Premio> premios;

    public CalculoPremio()
    {
        premios = new List<Premio>(); 
    }


    public void AdicionarPremio(Premio premio)
    {
        premios.Add(premio);
    }

    public decimal CalcularPremio(Premio premio)
    {
        decimal fatorTipo;
        switch (premio.TipoPremio.ToLower())
        {
            case "basic":
                fatorTipo = 1.0m;
                break;
            case "vip":
                fatorTipo = 1.2m;
                break;
            case "premium":
                fatorTipo = 1.5m;
                break;
            case "deluxe":
                fatorTipo = 1.8m;
                break;
            case "special":
                fatorTipo = 2.0m;
                break;
            default:
                throw new ArgumentException("Tipo de prêmio inválido.");
        }

        decimal fator = fatorTipo;
        if (premio.FatorProprio.HasValue && premio.FatorProprio > 0)
        {
            fator = premio.FatorProprio.Value; // Sobrescreve com o fator próprio
        }

        // Calcula o prêmio
        decimal valorPremio = premio.ValorBase * fator;

        // Valida o prêmio
        if (valorPremio <= 0)
        {
            throw new ArgumentException("O valor do prêmio não pode ser negativo ou zero.");
        }

        return valorPremio;
    }
}
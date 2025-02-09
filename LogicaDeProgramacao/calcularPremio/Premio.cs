using System;

public class Premio
{
    public decimal ValorBase { get; set; }
    public string TipoPremio { get; set; }
    public decimal? FatorProprio { get; set; } 
    public Premio(decimal valorBase, string tipoPremio, decimal? fatorProprio = null)
    {
        ValorBase = valorBase;
        TipoPremio = tipoPremio;
        FatorProprio = fatorProprio;
    }
}
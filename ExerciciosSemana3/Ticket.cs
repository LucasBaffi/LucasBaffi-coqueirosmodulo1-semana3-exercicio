using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parking1
{
public class Ticket
{
    public DateTime Entrada { get; private set; }
    public DateTime Saida { get; private set; }
    public bool Ativo { get;  set; }
    
    public Ticket()
    {
        Entrada = DateTime.Now;
        Ativo = true;
    }

    public void MarcarSaida()
    {
        Saida = DateTime.Now;
        Ativo = false;
    }

    public double CalcularTempo()
    {
        var tempo = Saida - Entrada;
        return tempo.TotalMinutes;
    }

    public double CalcularValor()
    {
        var tempo = CalcularTempo();
        var valor = tempo * 0.09;
        return valor;
    }
    

}


}
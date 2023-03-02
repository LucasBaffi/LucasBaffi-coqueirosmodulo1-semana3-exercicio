using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace parking1
{
    public class Ticket
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public bool Ativo { get; set; }

        public Ticket()
        {
            Entrada = DateTime.Now;
            Ativo = true;
        }

        public void MarcarSaida()
        {
            Saida = DateTime.Now;
            Ativo = false;

            Console.WriteLine($"O veiculo ficou{CalcularTempo()} minutos e o valor cobrado sera de {CalcularValor()}");
        }

        public double CalcularTempo()
        {
            var tempo = Saida - Entrada;
            return tempo.TotalMinutes;
        }

        public double CalcularValor()
        {

            return CalcularTempo() * 0.09;
        }



    }


}
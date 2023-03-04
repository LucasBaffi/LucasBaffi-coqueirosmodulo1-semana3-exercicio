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

        public void ticket()
        {
            Entrada = DateTime.Now;
            Ativo = true;
        }

        public void MarcarSaida()
        {
            Saida = DateTime.Now;
            Ativo = false;

            var tempo = CalcularTempo(); // calcula o tempo em minutos
            Console.WriteLine($"O veiculo ficou{tempo - 1} minutos e o valor cobrado sera de {CalcularValor()}");
        }

        public double CalcularTempo()
        {
            var tempo = Saida - Entrada;
            return tempo.TotalMinutes;
        }

        public double CalcularValor()
        {

            double valor = CalcularTempo() * 0.09;
            return Math.Round(valor, 2);
        }



    }


}
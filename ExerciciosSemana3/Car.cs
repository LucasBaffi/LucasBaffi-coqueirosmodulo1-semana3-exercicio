using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parking
{
   public class Carro
{
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public string Marca { get; set; }
    public List<Ticket> Tickets { get; set; }

    public Carro(string placa, string modelo, string cor, string marca)
    {
        Placa = placa;
        Modelo = modelo;
        Cor = cor;
        Marca = marca;
        Tickets = new List<Ticket>();
    }

    public static void CadastrarCarro()
{
    Console.WriteLine("Digite os dados do carro:");
    Console.Write("Placa: ");
    string placa = Console.ReadLine();
    Console.Write("Modelo: ");
    string modelo = Console.ReadLine();

    Carro novoCarro = new Carro(placa, modelo);
    carrosCadastrados.Add(novoCarro);

    Console.WriteLine("Carro cadastrado com sucesso!");
}
    
}

}
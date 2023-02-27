// See https://aka.ms/new-console-template for more information

using parking;
using parking1;
// Criando um novo ticket
Ticket ticket = new Ticket();

// Fazendo a saída do veículo e calculando o valor
ticket.SaidaVeiculo();
double valor = ticket.CalcularValor();
Console.WriteLine($"Valor a ser cobrado: R$ {valor:f2}");

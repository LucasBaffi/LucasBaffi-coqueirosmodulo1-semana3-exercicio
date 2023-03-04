using parking;
using parking1;


//lista estatica car
List<Car> cars = new List<Car>();


string opcao;
do
{
    Console.WriteLine("olá bem vindo ao estacionamento Pare aqui , selecione a opcao desejada");
    Console.WriteLine("1 - Cadastrar carro ");
    Console.WriteLine("2 - Marcar Entrada ");
    Console.WriteLine("3 - Marcar Saida ");
    Console.WriteLine("4 - Consultar Historico ");
    Console.WriteLine("5 - Sair ");
    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        CadastrarCarro();
    } 
    if (opcao == "2")
    {
        GerarTicket();
    } 
    if (opcao == "3")
    {
        FecharTicket();
    } if (opcao == "4")
    {
        Historico();
    }


} while (opcao != "5");

void CadastrarCarro()
{
    //instanciar a classe carro
    Car car = new Car();
    Console.WriteLine("Digite a placa do carro");
    car.Placa = Console.ReadLine();
    Console.WriteLine("Digite o modelo");
    car.Modelo = Console.ReadLine();

    Console.WriteLine("Digite a cor");
    car.Cor = Console.ReadLine();

    Console.WriteLine("Digite a marca do carro");
    car.Marca = Console.ReadLine();

    cars.Add(car);
}

Car ObterCarro(string placa)
{
    foreach (var car in cars)
    {
        if (placa == car.Placa)
        {
            return car;
        }
    }
    return null;
}

void GerarTicket()
{
    Console.WriteLine("Qual a placa do veiculo?");
    string placa = Console.ReadLine();
    var car = ObterCarro(placa);
    if (car == null)
    {
        Console.WriteLine("Carro nao encontrado");
        return;
    }
    foreach (var ticket in car.Tickets)
    {
        if (ticket.Ativo == true)
        {
            Console.WriteLine("Veiculo ja esta no estacionamento");
            return;
        }

    }


    Ticket NewTicket = new Ticket();
    NewTicket.Ativo = true;
    car.Tickets.Add(NewTicket);
    Console.WriteLine("Ticket gerado");
}

void FecharTicket()
{
    Console.WriteLine("Qual a placa do veiculo?");
    string placa = Console.ReadLine();
    var car = ObterCarro(placa);
    if (car == null)
    {
        Console.WriteLine("Carro nao encontrado");
        return;
    }

    Ticket ticketAberto = null;
    foreach (var ticket in car.Tickets)
    {
        if (ticket != null || ticket.Ativo == true)
        {
            ticketAberto = ticket;
        }

    }
    if(ticketAberto == null){
             Console.WriteLine("nao ha tickets aberto para o veiculo");
        return;
        }
         ticketAberto.MarcarSaida(); 
    

}


void Historico(){
  Console.WriteLine("Qual a placa do veiculo?");
    string placa = Console.ReadLine();
    var car = ObterCarro(placa);
    if (car == null)
    {
        Console.WriteLine("Carro nao encontrado");
        return;
    }

Console.WriteLine("Entrada               |Saida              |Ativo             |Valor ");

//percorrer os tickets
foreach(var ticket in car.Tickets){
Console.WriteLine($"{ticket.Entrada}  | {ticket.Saida} | {ticket.Ativo.ToString()} | R${ticket.CalcularValor()}");
}
}
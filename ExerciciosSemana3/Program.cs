using parking;
using parking1;

List<Car> cars = new List<Car>();


string opcao;
do
{
    Console.WriteLine("/n/nOlá bem vindo ao estacionamento Pare aqui , selecione a opcao desejada");
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
} while (opcao != "5");

void CadastrarCarro()
{
    //instanciar a classe carro
    Car car = new Car();
    Console.WriteLine("Digite a placa do carro");
    car.Placa = Console.ReadLine();
    Console.WriteLine("Digite a placa do modelo");
    car.Modelo = Console.ReadLine();

    Console.WriteLine("Digite a placa do cor");
    car.Cor = Console.ReadLine();

    Console.WriteLine("Digite a placa do marca");
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

void GerarTicket(){
    Console.WriteLine("Qual a placa do veiculo?");
    string placa = Console.ReadLine();
    var car = ObterCarro(placa);
    if(car == null){
        Console.WriteLine("Carro nao encontrado");  
        return;
    }
    foreach(var ticket in car.Tickets){
        if(ticket.ativo == true){
            Console.WriteLine("Veiculo ja esta no estacionamento");  
        return;
        }

    }
}

Ticket ticketNovo = new Ticket();
ObterCarro.Tickets
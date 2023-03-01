using parking;
using parking1;

List<Car> cars = new list<Car>();

string opcao;
do
{
    Console.WriteLine("/n/nOlá bem vindo ao estacionamento Pare aqui , selecione a opcao desejada");
    Console.WriteLine("1 - Cadastrar carro ");
    Console.WriteLine("2 - MArcar Entrada ");
    Console.WriteLine("3 - Marcar Saida ");
    Console.WriteLine("4 - Consultar Historico ");
    Console.WriteLine("5 - Sair ");
    opcao = Console.Read();

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
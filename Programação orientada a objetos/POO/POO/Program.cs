using POO;

//1. instancia o objeto
var carroCivic = new Car();

//2. Define as informações
carroCivic.Name = "Honda Civic";
carroCivic.color = "dark blue";
carroCivic.Year = 2025;
carroCivic.Model = "Sport HEV";
carroCivic.Brand = "Honda";

//3.printa
Console.WriteLine("Nome do carro: " + carroCivic.Name);
Console.WriteLine("Cor: " + carroCivic.color);
Console.WriteLine("Ano: " + carroCivic.Year);
Console.WriteLine("Modelo: " + carroCivic.Model);
Console.WriteLine("Marca: " + carroCivic.Brand);
Console.WriteLine("\n ------------------------------------ \n");

//4. Lista de carros
List<Car> CarList = new List<Car>();
CarList.Add(carroCivic);

foreach (Car car in CarList)
{
    Console.WriteLine("Nome do carro: " + car.Name);
    Console.WriteLine("Cor: " + car.color);
    Console.WriteLine("Ano: " + car.Year);
    Console.WriteLine("Modelo: " + car.Model);
    Console.WriteLine("Marca: " + car.Brand);

}
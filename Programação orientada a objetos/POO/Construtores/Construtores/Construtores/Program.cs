
using Construtores;

//Cake cake = new Cake();

//Console.WriteLine($"Sabor: {cake.Sabor}");
//Console.WriteLine($"Recheio: {cake.Recheio}");
//Console.WriteLine($"Cobertura de: {cake.Cobertura}");
//Console.WriteLine($"Número de camadas: {cake.Camadas}");
//Console.WriteLine($"Tamanho do bolo: {cake.Tamanho}");


//CONSTRUTORES POR PARAMETRO

Cake boloDeChocolate = new Cake("Chocolate", "morango", "chocolate", 3, "Familia");
Console.WriteLine($"Sabor: {boloDeChocolate.Sabor}");
Console.WriteLine($"Recheio: {boloDeChocolate.Recheio}");
Console.WriteLine($"Cobertura de: {boloDeChocolate.Cobertura}");
Console.WriteLine($"Número de camadas: {boloDeChocolate.Camadas}");
Console.WriteLine($"Tamanho do bolo: {boloDeChocolate.Tamanho}");

Console.WriteLine("\n================================= \n");

Cake boloDeMorango = new Cake("morango", "baunilha", "glacê", 2, "Gigante");
Console.WriteLine($"Sabor: {boloDeMorango.Sabor}");
Console.WriteLine($"Recheio: {boloDeMorango.Recheio}");
Console.WriteLine($"Cobertura de: {boloDeMorango.Cobertura}");
Console.WriteLine($"Número de camadas: {boloDeMorango.Camadas}");
Console.WriteLine($"Tamanho do bolo: {boloDeMorango.Tamanho}");
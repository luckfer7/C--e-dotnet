
Console.WriteLine("LISTAS");

//1. Declaração com inicialização de valores. 
//a. usa-se a palavra reservada list
//b. passa-se o tipo dos valores entre os sinais de maior e menor
//c. passa-se o nome da váriavel.
//d. o que vem depois.
//e. passa-se os valores entre chaves
List<string> heroes = new List<string>()
{
    "Super man",
    "Batman",
    "Homem aranha",
    "Wolverine",
    "Super choque"
};

//2. acessando valores
Console.WriteLine(heroes[2]);

heroes.Add("Jean gray");
heroes.Add("Mulher maravilha");

foreach (string hero in heroes)

{
    Console.WriteLine(hero);
}

Console.WriteLine("-------------------------");

heroes.Remove("Super man");
foreach (string hero in heroes)
{
    Console.WriteLine(hero);    
}

Console.WriteLine("-------------------------");
heroes[0] = "Homem de ferro";
foreach (string hero in heroes)
{
    Console.WriteLine(hero);
}
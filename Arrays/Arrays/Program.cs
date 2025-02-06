
Console.WriteLine("ARRAYS\n");
//1. Declarando arrays:
//a. dizer o tipo: int, string, etc
//b. nome da variavel
//c. valores do arrays
string[] bebidas = { "leite", "água", "suco", "Refrigerante\n" };

//2. Acessando os valores
//Podemos acessar os valores dentro do array através do seu indice
Console.WriteLine(bebidas[0]);

foreach (string bebida in bebidas)
{
    Console.WriteLine(bebida);
}


//3. Podemos também contar indices usando o .Length.
Console.WriteLine("Quantidade de bebidas: " + bebidas.Length);


//4. Podemos trocar valores dentro dos arrays

bebidas[0] = "Cerveja";
foreach (string bebida in bebidas)
{
    Console.WriteLine(bebida);
}

//5. Declaraçao de arrays sem incializar
int[] numeros = new int[3]; //precisamos passar a quantidade de indices que esse array terá.

numeros[0] = 51;
numeros[1] = 69;
numeros[2] = 84;

foreach(int num in numeros)
{
    Console.WriteLine(num);
}

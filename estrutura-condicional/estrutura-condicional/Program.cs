
Console.WriteLine("=======VERIDICADOR DE NÚMEROS IMPARES OU PARES=======");

int number = Convert.ToInt32(Console.ReadLine());

int result = number % 2;

if(result == 0)
{
    Console.WriteLine("O numero é par");
}
else
{
    Console.WriteLine("O numero é impar");
}

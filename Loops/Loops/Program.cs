
Console.WriteLine("ESTRUTURAS DE REPETIÇÃO");
//int i = 0;

//while (i <= 5)
//{
//    Console.WriteLine($"número: {i}");
//    i++; //evita looping infinitos

//    //resultado no console:
//    //número: 0
//    //número: 1
//    //número: 2
//    //número: 3
//    //número: 4
//    //número: 5

//}

Console.WriteLine("DO-WHILE");

//int j = 1;

//do
//{
//    Console.WriteLine(j);
//    j++;
//} while (j <= 10);
////faça a impressão e iteração da variável enquanto a condição for j menor que 10.
///

//Console.WriteLine("FOR-LOOP");

//for (int i = 0;  i < 10; i++)
//{
//    Console.WriteLine(i);
//}


Console.WriteLine("FOREACH-LOOP");
//O foreach é recomendado para coleções (listas)
List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
foreach (int number in numberList)
{
    int multiplicator = 2;
    int result = number * multiplicator;
    
    Console.WriteLine($"{number} x {multiplicator} = {result}");
}
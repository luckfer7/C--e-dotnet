
//int numberOne = Convert.ToInt32(Console.ReadLine());
//int numberTwo = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(numberOne + numberTwo);
//Console.WriteLine(numberOne - numberTwo);
//Console.WriteLine(numberOne * numberTwo);
//Console.WriteLine(numberOne / numberTwo);
//Console.WriteLine(numberOne % numberTwo);

//OPERADORES DE ATRIBUIÇÃO
//Console.WriteLine("(=)");

////ATRIBUIÇÃO COMPOSTA
////++
////--
////ETC

//int x = 20;
//x++; //o resultado é 21.
//Console.WriteLine(x);


//OPERADORES RELACIONAIS

//Console.WriteLine("======OPERADORES RELACIONAIS======\n");
//Console.WriteLine("Digite o primeiro número: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o segundo número: ");
//int b = Convert.ToInt32(Console.ReadLine());

//string result;

//if (a == b)
//{
//    result = "O número a é igual ao número b";
//}
//else if (b != a)
//{
//    result  = "O número a não é igual ao b";
//} 

//else if (a > b)
//{
//    result = "a é maior que b";
//}
//else if (a < b)
//{
//    result = "a é menor que b";
//}
//else
//{
//    result = "Os valores passados não são válidos";
//}

//Console.WriteLine(result);


//OPERADORES LÓGICOS

Console.WriteLine("========OPERADORES LÓGICOS=======");

//bool isLogged = true;
//bool hasAdminAccess = false;



//if (isLogged && hasAdminAccess)
//{
//    Console.WriteLine("Acesso ao painel de administrador concedido");
//}
//else
//{
//    Console.WriteLine("Você não tem acesso ao painel de administrador\n");
//}


//if (!isLogged)
//{
//    Console.WriteLine("Usuário não  está logado");
//}
//else
//{
//    Console.WriteLine("Usuário está logado");
//}

Console.WriteLine("========CALCULADORA SIMPLES========\n");
Console.WriteLine("Enter the first number: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
double number2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nEscolha uma operação: ");
Console.WriteLine("1 = Adição");
Console.WriteLine("2 = Subtração");
Console.WriteLine("3 = Multiplicação");
Console.WriteLine("4 = Divisão");

Console.WriteLine("Digite o número correspondente a operação: ");
int operation = Convert.ToInt32(Console.ReadLine());

double result = 0;

switch (operation)
{
    case 1:
        result = number1 + number2;
        break;

    case 2:
        result = number1 - number2;
        break;

    case 3:
        result = number1 * number2;
        break;

    case 4:
        result = number1 / number2;
        break;

    default:
        Console.WriteLine("Invalid input!");
        break;


}

//if (operation == 1)
//{
//    result = number1 + number2;
//}
//else if (operation == 2)
//{
//    result = number1 - number2;
//}
//else if (operation == 3)
//{
//    result = number1 * number2;
//}
//else if (operation == 4)
//{
//    result = number1 / number2;
//}
//else
//{
//    Console.WriteLine("Invalid input!");
//}

Console.WriteLine($"\nThe result of the operation is: {result}");
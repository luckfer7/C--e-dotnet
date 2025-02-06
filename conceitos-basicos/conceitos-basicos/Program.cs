using System.Reflection.Metadata;

Console.WriteLine("Hello world");

//string myName = "Lucas";
//string myLastName = "Camilo";
//int age = 26;
//double bankValue = 2.75;
//char charactere = 'a';
//bool boolean = false;

//Console.WriteLine($"Meu nome todo é {myName} {myLastName}. E eu tenho {age} anos. Na minha conta bancária tem {bankValue} reais");

//int number = 30;
//number = 20;
//Console.WriteLine(number);


//const int number = 50;


//Console.WriteLine(number);

//dynamic variablem = 20;

//variablem = "Lucas";
//Console.WriteLine(variablem); 


//Console.WriteLine("Quem é você");
//Console.WriteLine("Digite seu nome: ");
//string nome = Console.ReadLine();

//Console.WriteLine("Digite sua idade: ");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Seu nome é {nome} e voce tem {age} de idade!");
//Console.WriteLine($"Seu nome é {nome} e voce tem {age} de idade!");





Console.WriteLine("---------SISTEMA DE LOGIN---------");

string correctEmail = "teste@test.com";
string correctPassword = "password";

Console.WriteLine("Digite sua senha: ");
string password = Console.ReadLine();

Console.WriteLine("Digite seu email: ");
string email = Console.ReadLine();

if (email == correctEmail && password == correctPassword )
{
    Console.WriteLine("ACESSO PERMITIDO! BEM-VINDO DE VOLTA!");
}
else 
{
    Console.WriteLine("EMAIL OU SENHA ESTÃO INCORRETOS");
}



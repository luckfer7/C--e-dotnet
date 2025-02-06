
Console.WriteLine("Hello, World!");

string path = @"C:\Users\lucas\Desktop\C# e .NET\gerenciador de compras\";
string fileName = "Lista-de-comprar.txt";
string filepath = path + fileName;

List<string> shoppingList = new List<string>();

if(File.Exists(filepath))
{
    shoppingList.AddRange(File.ReadAllLines(filepath));
    //se o arquivo existe, subscreve nele.
}

while(true)
{
    Console.WriteLine("\n --- Lista de compra ---");
    Console.WriteLine("1. Adicionar item");
    Console.WriteLine("2. Remover item");
    Console.WriteLine("3. Exibir lista");
    Console.WriteLine("4. Sair");
    Console.WriteLine("Escolha um número para continuar");

    string choiceUser = Console.ReadLine();

    switch (choiceUser)
    {
        case "1":
            Console.WriteLine("Digite o nome do item para adicionar: ");
            string itemInsert = Console.ReadLine();
            shoppingList.Add(itemInsert);
            Console.WriteLine($"The item {itemInsert} has been sucessfully saved");
        break;

        case "2":
            Console.WriteLine("Digite o nome do item que você quer remover");
            string removedItem = Console.ReadLine();
            shoppingList.Remove(removedItem);
            Console.WriteLine($"The item {removedItem} has been sucessfully removed");
        break;

        case "3":
            Console.WriteLine("\n Iten in you shopping list: ");


            foreach (string itens in shoppingList)
            {
                Console.WriteLine(itens);
            }
        break;


    }
}
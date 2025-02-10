

Dictionary<string, string> contatos = new Dictionary<string, string>();

while (true)
{
    Console.WriteLine("\n=====Lista de contatos=====\n");
    Console.WriteLine("Digite a opção desejada: ");
    Console.WriteLine("1 - Adicionar um novo contato");
    Console.WriteLine("2 - Mostrar contatos na lista");
    Console.WriteLine("3 - Buscar contato");
    Console.WriteLine("4 - Remover contato");
    Console.WriteLine("5 - sair do programa");

    int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

    switch(opcaoEscolhida)
    {
        case 1:
            Console.WriteLine("Digite nome e telefone a ser adicionado:");
            string nome = Console.ReadLine();
            string numero = Console.ReadLine();
            contatos.Add(nome, numero);
            Console.WriteLine("Contato foi salvo com sucesso");
        break;

        case 2:
           
            if(contatos.Count == 0)
            {
                Console.WriteLine("Não há contatos na lista");
            }
            else
            {
                Console.WriteLine("\nContatos salvos na sua lista:");
                foreach (var contato in contatos)
                {
                    Console.WriteLine($"Nome: {contato.Key} - Número: {contato.Value}");
                }
            }
            
        break;

        case 3:
            Console.WriteLine("Qual contato você deseja buscar?");
            string contatoDigitado = Console.ReadLine();
            if(contatos.TryGetValue(contatoDigitado, out string numeroContato))
            {
                //armazena o valor na variável numeroContato
                Console.WriteLine(numeroContato);
            } 
            else
            {
                Console.WriteLine("O contato buscado não existe!");
            }
        break;

        case 4:
            Console.WriteLine("Qual contato que você deseja remover?");
            string contatoRemovido = Console.ReadLine();

            //verificando se o contato existe antes de remover
            if (contatos.ContainsKey(contatoRemovido))
            {
                contatos.Remove(contatoRemovido);
                Console.WriteLine("O contato foi removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Este contato não existe na lista");
            }
            
        break;
          
        case 5:
            Console.WriteLine("Tem certeza que deseja sair do programa");
            string resposta = Console.ReadLine();
            

            if (resposta == "sim")
            {
                Console.WriteLine("Encerrando o programa...");
                Environment.Exit(0);
            }
            else  
            {
                Console.WriteLine("Voltando ao menu...");
            }
        break;
    }


}

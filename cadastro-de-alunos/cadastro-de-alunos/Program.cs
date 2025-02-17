
//Aluno aluno1 = new Aluno();
//aluno1.nome = "Lucas";
//aluno1.idade = 26;
//aluno1.nota = 10;
//Console.WriteLine($"Aluno: {aluno1.nome}");
//Console.WriteLine($"Idade: {aluno1.idade}");
//Console.WriteLine($"Nota: {aluno1.nota}");

//ao invés de usar o console, podemos apenas chamar o método que criamos na classe.
//passamos o nome do aluno e o método.

Escola escola = new Escola();

while(true)
{

    Console.WriteLine("\n---CADASTRO DE ALUNOS---\n");
    Console.WriteLine("1. Adicionar aluno");
    Console.WriteLine("2. Listar alunos");
    Console.WriteLine("3. buscar aluno");
    Console.WriteLine("4. Sair do programa");

    int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

    switch (opcaoEscolhida)
    {
        case 1:
            //para chamar o método eu preciso criar uma instancia da classe escola antes do while.
            escola.AdicionarAluno();
            break;

        case 2:
            escola.ListarAlunos();
            break;

        case 3:
            escola.FiltraAlunoPeloNome();
            break;

        case 4:
            Console.WriteLine("Saindo do programa...");
            Environment.Exit(0);
            break;

    }
}

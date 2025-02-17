class Escola
{
    //precisamos criar uma lista de alunos que vão conter objetos do tipo aluno, não apenas nomes.

    private List<Aluno> alunos = new List<Aluno>();

    public void AdicionarAluno()
    {

        Console.Write("Digite o nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a idade do aluno: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a nota do aluno no primeiro bimestre: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota do aluno no segundo bimestre: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Digite a nota do aluno no terceiro bimestre: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Digite a nota do aluno no quarto bimestre: ");
        double nota4 = Convert.ToDouble(Console.ReadLine());

        //aqui, cria-se um novo aluno e o adiciona numa lista
        Aluno novoAluno = new Aluno(nome, idade, nota1, nota2, nota3, nota4);
        alunos.Add(novoAluno);

        Console.WriteLine("Aluno adicionado com sucesso.");
    }
    public void ListarAlunos()
    {
        foreach (Aluno aluno in alunos)
        {
            aluno.ExibirInformacoes();
            aluno.VerificarAprovacao();
        }
    }


    //Devemos colocar aqui pq essa classe é uma classe de gerenciamento.
    public void FiltraAlunoPeloNome()
    {
        Console.WriteLine("Qual aluno você deseja ver as informações? Digite o nome dele abaixo: ");
        string nomeDigitado = Console.ReadLine();

        //variável de controle
        //a variável ajuda a evitar que a mensagem de erro seja exibida múltiplas vezes e garante que a verificação só aconteça no final do laço.
        //Ela proporciona uma maneira mais controlada e segura de exibir a mensagem de erro uma única vez ao final do processo, caso o aluno não tenha sido encontrado.
        bool alunoEncontrado = false;

        foreach (Aluno aluno in alunos)
        {
            if (aluno.Nome == nomeDigitado)
            {
                aluno.ExibirInformacoes();
                aluno.VerificarAprovacao();
                alunoEncontrado = true;
                break;
            }
            
        }
        if (!alunoEncontrado)
            {
                Console.WriteLine("O nome digitado não se encontr na lista!");
            }
    }
}
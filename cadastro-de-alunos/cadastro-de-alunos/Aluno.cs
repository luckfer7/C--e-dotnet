using System.Threading.Channels;

class Aluno
{
    //atributos
    public string Nome {  get; set; }
    public int Idade { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }
    public double Nota4 { get; set; }

    public double Media { get; set; }

    //construtor para inicializar um aluno 
    public Aluno(string nome, int idade, double nota1, double nota2, double nota3, double nota4)
    {
        Nome = nome;
        Idade = idade;
        Nota1 = nota1;
        Nota2 = nota2;
        Nota3 = nota3;
        Nota4 = nota4;
        Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
    }

    //método
    public void ExibirInformacoes()
    {
        Console.WriteLine("\n--- Dados do alunos ---");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"Nota do primeiro bimestre: {Nota1}");
        Console.WriteLine($"Nota do segundo bimestre: {Nota2}");
        Console.WriteLine($"Nota do terceiro bimestre: {Nota3}");
        Console.WriteLine($"Nota do quarto bimestre: {Nota4}");
        Console.WriteLine($"A média final foi: {Media}");
    }

    public void VerificarAprovacao()
    {
        //para verificar se a nota do aluno é maior que 7,utilizamos o atributo "Nota".
        //Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
        
        if (Media >= 7)
        {
            Console.WriteLine("Aluno aprovado");
        }
        else
        {
            Console.WriteLine("Aluno reprovado!");
        }
    }
}


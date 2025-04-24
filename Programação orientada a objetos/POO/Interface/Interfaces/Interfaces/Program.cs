using Interfaces;

IFuncionario[] equipe = new IFuncionario[] { new Designer(), new Programador() };
foreach (var funcionario in equipe)
{
    funcionario.Trabalhar();
}
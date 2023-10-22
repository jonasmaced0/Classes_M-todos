Console.WriteLine("\n## Passando Parametros entre as Classes ##\n");

Aluno aluno1 = new Aluno();

Console.WriteLine("Digite o nome do aluno: ");
aluno1.Nome = Console.ReadLine();
Console.WriteLine("Digite a idade do aluno: ");
aluno1.Idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o sexo do aluno: ");
aluno1.Sexo = Console.ReadLine();
Console.WriteLine("O aluno foi Aprovado? (S)im ou (N)ão: ");
aluno1.Aprovado = Console.ReadLine();

Curso curso001 = new Curso();

curso001.Resultado(aluno1);

Console.ReadKey();


public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {

    }

}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"O {aluno.Nome} do sexo {aluno.Sexo} de {aluno.Idade} anos.\n");
        if( aluno.Aprovado == "S")
        {
            Console.WriteLine("O aluno foi Aprovado!");
        }
        else
        {
            Console.WriteLine("O aluno foi Reprovado!");
        }
    }
}
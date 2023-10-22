
Console.WriteLine("\n## MÉTODO CONSTRUTOR \n");


Aluno aluno1 = new Aluno("Jonas", 23, "Masculino", "S");

Console.WriteLine(aluno1.Nome);
Console.WriteLine(aluno1.Idade);
Console.WriteLine(aluno1.Sexo);
Console.WriteLine(aluno1.Aprovado);


Console.ReadKey();


public class Aluno
{
    public Aluno(string nome, int idade, string sexo, string aprovado)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}
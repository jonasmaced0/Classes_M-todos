Console.WriteLine("\n## MAIS DE UM MÉTODO CONSTRUTOR \n");

Aluno aluno1 = new Aluno("Jonas", 22, "Masculino", "S");

Console.WriteLine(aluno1.Nome == null ? "Null": aluno1.Nome);
Console.WriteLine(aluno1.Idade == 0 ? "Null" : aluno1.Idade);
Console.WriteLine(aluno1.Sexo == null ? "0" : aluno1.Sexo);
Console.WriteLine(aluno1.Aprovado == null ? "Null" : aluno1.Aprovado);


Console.ReadKey();


public class Aluno
{
    public Aluno(string nome)=> Nome = nome;

    public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}
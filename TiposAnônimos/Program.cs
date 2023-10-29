
Console.WriteLine("\n\nTipos Anônimos\n\n");

var aluno = new
{
    Nome = "João",
    Idade = 12,
    Email = "joaomacedomaquina@gmail.com",
    Endereco = new
    {
        Id = 1,
        Cidade = "Santos",
        Estado = "SP",
        País = "Brasil"
    }
};

Console.WriteLine($"O aluno {aluno.Nome} tem {aluno.Idade} anos, e ele mora na cidade de {aluno.Endereco.Cidade}.");

Console.ReadKey();  

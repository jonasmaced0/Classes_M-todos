Console.WriteLine("## Classes e Métodos ##");

Pessoa p1 = new Pessoa();
p1.nome = "Maria";
p1.idade = 29;
p1.sexo = "feminino";

Console.WriteLine($"A aluna {p1.nome} tem {p1.idade} anos, e é do sexo {p1.sexo}");

Pessoa p2 = p1;

//Pessoa p2 = new Pessoa();
//p2.nome = "Jonas";
//p2.idade = 30;
//p2.sexo = "masculino";

Console.WriteLine($"O aluno {p2.nome} tem {p2.idade} anos, e é do sexo {p2.sexo}");



Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}
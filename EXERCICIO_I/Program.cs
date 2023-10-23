
Console.WriteLine("\n## Exercicio 1 ##\n");

var chevrolet = new Carro();

Console.WriteLine("Digite o modelo do carro:\n");
chevrolet.Modelo = Console.ReadLine();

Console.WriteLine("Digite a montadora do carro:\n");
chevrolet.Montadora = Console.ReadLine();

Console.WriteLine("Digite a categoria carro:\n");
chevrolet.Categoria = Console.ReadLine();

Console.WriteLine("Digite o ano carro:\n");
chevrolet.Ano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a potência carro:\n");
chevrolet.Potencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O primeiro carro escolhido é o {chevrolet.Modelo}, um {chevrolet.Categoria} da {chevrolet.Montadora}, ano {chevrolet.Ano} com {chevrolet.Potencia} CV.\n");
chevrolet.Acelear();

var ford = new Carro("New Territory", "Ford", "SUV", 2024, 140);
Console.WriteLine($"O segundo carro escolhido é o {ford.Modelo}, um {ford.Categoria} da {ford.Montadora}, ano {ford.Ano} com {ford.Potencia} CV.\n");
ford.Acelear();


Console.ReadKey();

public class Carro
{
    public Carro()
    {

    }

    public Carro(string? Modelo, string? Montadora, string? Categoria, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Categoria = Categoria;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public string? Modelo;
    public string? Montadora;
    public string? Categoria;
    public int Ano;
    public int Potencia;

    public void Acelear()
    {
        Console.WriteLine($"Acelerando meu {this.Montadora}\n");
    }

}

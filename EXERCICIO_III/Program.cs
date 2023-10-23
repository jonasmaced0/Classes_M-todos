Console.WriteLine("\n## Exercicio 3 ##\n");


var ford = new Carro("New Territory", "Ford", "SUV", 2024, 140);
Console.WriteLine($"O segundo carro escolhido é o {ford.Modelo}, um {ford.Categoria} da {ford.Montadora}, ano {ford.Ano} com {ford.Potencia} CV.\n");
ford.Acelear();

var novaPotencia = ford.AumentarPotencia(ford.Potencia);

Console.WriteLine($"A nova potência do {ford.Modelo} é de {novaPotencia} CV");
Console.WriteLine($"{ford.Potencia}");


var novaPotencia2 = ford.AumentarPotencia(ref novaPotencia);

Console.WriteLine($"A nova potência do {ford.Modelo} é de {novaPotencia2} CV");
Console.WriteLine($"{novaPotencia}");



Console.ReadKey();

public class Carro
{

    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
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

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotencia(int potencia)
    {
        return potencia += 3;
    }

    public int AumentarPotencia(ref int potencia)
    {
        return potencia += 5;
    }



}

Console.WriteLine("\n## Exercicio 6 ##\n");

var ford = new Carro("New Territory", "Ford", "SUV", 2024, 140);

Carro.ObterValorIPVA();
Console.WriteLine(Carro.ValorIpva);

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
    public static double ValorIpva;

    public void Acelear()
    {
        Console.WriteLine($"Acelerando meu {this.Montadora}\n");
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

    public void ExibirInfo(string? modelo, string? montadora, string? categoria, int potencia, int ano = 2021)
    {

        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Montadora: {montadora}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"Potencia: {potencia}");
        Console.WriteLine($"Ano: {ano}");
    }

    public static void ObterValorIPVA()
    {
        ValorIpva = 4;
    }

}
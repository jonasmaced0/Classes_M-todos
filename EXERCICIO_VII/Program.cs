
using System.Reflection;

Console.WriteLine("\n\n EXERCICIO 7 \n\n");

var ford = new Carro("New Territory", "Ford", "SUV", 2007, 140);

ford.ExibirInfo();


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

    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if( value < 2000)
            {
                ano = 2000;
            }
            else if ( value > 2022) {
                ano = 2022;
            }
            else
            {
                 ano = value;
            }
        }
    }

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

    public void ExibirInfo()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Montadora: {Montadora}");
        Console.WriteLine($"Categoria: {Categoria}");
        Console.WriteLine($"Potencia: {Potencia}");
        Console.WriteLine($"Ano: {Ano}");
    }

    public static void ObterValorIPVA()
    {
        ValorIpva = 4;
    }

}
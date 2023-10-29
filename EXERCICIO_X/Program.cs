
Console.WriteLine("\n## Exercicio 10 ##\n");


Console.WriteLine("  Menu de cores para o Carro  \n\n");
Console.WriteLine($"{Cores.Branco} - Opção: {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - Opção: {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - Opção: {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - Opção: {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - Opção: {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - Opção: {(int)Cores.Azul}\n\n");


Console.WriteLine("Digite a opção da cor do veículo:");
var opcao = Convert.ToInt32(Console.ReadLine());

var cor = (Cores)opcao;

Carro carro = new("T-Cross", "Volkswagen", "SUV", 2023, 140, opcao);

carro.ExibirInfo(carro.Modelo, carro.Montadora, carro.Categoria, carro.Ano, carro.Potencia, carro.Cor);

Console.ReadLine();

public class Carro

{
    static Carro()
    {
        {
            ValorIpva = 4;
        }
    }

    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }
    public Carro(string? Modelo, string? Montadora, string? Categoria, int Ano, int Potencia, int Cor)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Categoria = Categoria;
        this.Ano = Ano;
        this.Potencia = Potencia;
        this.Cor = Cor;

    }

    public int Cor;
    public string? Modelo;
    public string? Montadora;
    public string? Categoria;

    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
            {
                ano = 2000;
            }
            else if (value > 2022)
            {
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

    public void ExibirInfo(string? modelo, string? montadora, string? categoria, int potencia, int ano = 2021, int cor = 2)
    {

        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Montadora: {montadora}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"Potencia: {potencia}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Cor: {(Cores)cor}");
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Montadora: {Montadora}");
        Console.WriteLine($"Categoria: {Categoria}");
        Console.WriteLine($"Potencia: {Potencia}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Cor: {Cor}");
    }

    

}


enum Cores
{
    Branco = 1,
    Vermelho,
    Preto,
    Cinza,
    Prata,
    Azul
}
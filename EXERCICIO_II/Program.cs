Console.WriteLine("\n## Exercicio 1 ##\n");


Carro Onix = new Carro("Onix", "Chevrolet");


Console.WriteLine(Onix.Modelo == null? "Null": Onix.Modelo);
Console.WriteLine(Onix.Montadora == null? "Null": Onix.Montadora);
Console.WriteLine(Onix.Categoria == null? "Null": Onix.Categoria);
Console.WriteLine(Onix.Ano == 0? 0 : Onix.Ano);
Console.WriteLine(Onix.Potencia == 0 ? 0 : Onix.Potencia);

Onix.VelocidadeMaxima(110);

Console.WriteLine(Onix.VelocidadeMaxima(110));


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
        return potencia*1.75;
    }

}


// Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro.

// Ao criar um objeto do tipo Carro usando o novo método construtor que utiliza apenas os
// atribitos Modelo e Montadora, irá adicionar valor apenas a esses dois atributos, os outros
// três atributos ficaram sem valor, no caso Ano e Potencia terão valor = 0 e Categoria terá
// o valor igual a null.


// Quando um método retorna algum valor, ele não é void, portando para retornar algum valor
// é preciso utilizar a palavra reservada "return", no qual irá retornar um valor do mesmo
// tipo declarado no método, após a o tipo de privacidade do método.
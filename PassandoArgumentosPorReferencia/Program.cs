
Console.WriteLine("## PASSAGEM DE ARGUMENTOS POR VALOR E REFERÊNCIA ##");

// Exemplo de passagem de arguemento por referencia com REF

int x = 20;
Console.WriteLine($"\nO valor do argumento x antes de passar por valor: {x}");

Calculo calculo = new Calculo();
calculo.Dobrar(ref x);

Console.WriteLine($"\nO valor do argumento x depois de passar por valor: {x}");


Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine($"\n O valor do parâmetro y no método Dobrar: {y}");
    }
}
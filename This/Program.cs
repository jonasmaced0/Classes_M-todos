Console.WriteLine("\n## THIS \n");

Teste t1 = new Teste();

t1.Num1 = 10;
t1.Num2 = 20;
t1.Exibir();

Teste t2 = new Teste();

t2.Num1 = 30;
t2.Num2 = 40;
t2.Exibir();

Console.ReadKey();

public class Teste
{
    public int Num1;
    public int Num2;

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine($"Num 1: {Num1}");
        Console.WriteLine($"Num 2: {Num2}");
    }

    public void Exibir()
    {
        PassarParametro(this);
    }
}

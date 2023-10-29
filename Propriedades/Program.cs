Console.WriteLine("Trabalhando com propriedades\n\n\n");

Produto p1 = new();

p1.Nome = "Filé de Tilápia";
p1.Preco = 12.99;
p1.EstoqueMinimo = 12;

p1.Exibir();


Console.ReadKey();

public class Produto
{
    private string? nome;
    public string? Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value; }
    }

    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
        }
    }

    private double desconto = 0.05;
    public double Desconto
    {
        get { return desconto; }

    }

    public double PrecoFinal
    {
        get { return Preco - (Preco * Desconto); }
    }

    private int estoqueminimo;
    public int EstoqueMinimo
    {
        set { estoqueminimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($" Nome: {Nome}\n Preço: {Preco}\n Desconto: {Desconto}\n Preço Final: {PrecoFinal}" +
            $"\n EstoqueMinimo:{estoqueminimo}");
    }
}








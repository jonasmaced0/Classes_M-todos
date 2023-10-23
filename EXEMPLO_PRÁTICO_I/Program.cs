Console.WriteLine("Exercício Prático");

Cadastro cadastro = new Cadastro();
var Marcelo = cadastro.Registrar();

cadastro.ExibirDados(Marcelo);

cadastro.Registrar(Marcelo);

cadastro.ExibirDados(Marcelo, "Renda Alterada");


Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;
    public int Renda;

    public Cliente(string? nome, int idade, int renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    public Cliente()
    {
        
    }
}

public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new Cliente("Marcelo", 23,3000);
        return cliente;
    }

    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }

    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"O cliente {cliente.Nome}, tem {cliente.Idade} anos e possui a renda de R${cliente.Renda}");
    }

    public void ExibirDados(Cliente cliente, string texto)
    {
        Console.WriteLine($"{texto}");
        Console.WriteLine($"A Renda do cliente foi alterada para R${cliente.Renda}");
    }
}


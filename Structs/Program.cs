Console.WriteLine("\n    STRUCTS    \n");

Cliente cliente = new Cliente();

cliente.Nome = "Jonas";
cliente.Idade = 23;

Console.WriteLine($"O nome do cliente é {cliente.Nome}, e ele tem {cliente.Idade} anos");

Console.ReadKey();


public struct Cliente
{
    public string? Nome;
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

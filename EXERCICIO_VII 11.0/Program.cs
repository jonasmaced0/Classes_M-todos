
Console.WriteLine("EXERCICIO 8");

Cliente cliente = new Cliente("Maria", "maria@gmail.com", 20);

Cliente.ExibirInfo(cliente.Nome, cliente.Email, cliente.Idade);
Cliente.ExibirInfo(cliente.Nome, cliente.Email);


public struct Cliente
{
    public string Nome;
    public string Email;
    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
            {
                idade = 18;
                Console.WriteLine("Cliente menor que 18 anos");
            }
            else
            {
                Console.WriteLine("Cliente maior que 18 anos");
                idade = value;
            }
        }
    }
    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }
    public static void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"{nome} - {email} - {idade}");
    }
}
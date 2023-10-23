
Console.WriteLine("\n## SOBRECARGA DE MÉTODOS ##\n");

Email email = new Email();

email.Enviar("jonasvbo@gmail.com");
email.Enviar(10, "jonasvbo@gmail");
email.Enviar("jonasvbo@gmail.com", 20);
email.Enviar("jonasvbo@gmail.com", "VASCO");



Console.ReadKey();

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto Padrão");
        Console.WriteLine("\n");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
        Console.WriteLine("\n");
    }

    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta comercial");
        Console.WriteLine($"{valor}");
        Console.WriteLine("\n");
    }

    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento forncedor");
        Console.WriteLine($"{valor}");
        Console.WriteLine("\n");
    }
}
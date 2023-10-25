Console.WriteLine("## Argumentos Nomeados ##");


Email email = new();

email.Enviar(titulo: "URGENTE", destino: "jonasvbo@gmail.com", assunto: "Orçamento 2024");


Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\n Para {destino} - {titulo} \n Assunto: {assunto}");
    }
}



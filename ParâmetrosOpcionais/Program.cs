Console.WriteLine("\n\n## Parâmetros Opcionais ##\n\n");

Email email = new();

email.Enviar(destino: "jonasvbo@gmail.com");


Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo = "Metas 2024", string assunto = "Orçamento de Marketing")
    {
        Console.WriteLine($"\n Para {destino} - {titulo} \n Assunto: {assunto}");
    }
}

Console.WriteLine("## Metódos com parâmetros ##\n");


string nomeCompleto = "Jonas Vieira Macedo";
string dataAtual = DateTime.Now.ToLongDateString();

MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao(nomeCompleto, dataAtual);

Console.ReadKey();

public class MinhaClasse
{
    public void Saudacao(string nome,string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}

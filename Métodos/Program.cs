
Console.WriteLine("Métodos\n");

MinhaClase minhaClasse = new MinhaClase();

minhaClasse.Saudacao();
//minhaClasse.ExibirDataAtual();

Console.ReadKey();

class MinhaClase
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-Vindo");
        ExibirDataAtual();

    }

    public void ExibirDataAtual() =>
        Console.WriteLine(DateTime.Now.ToShortDateString());
    
}

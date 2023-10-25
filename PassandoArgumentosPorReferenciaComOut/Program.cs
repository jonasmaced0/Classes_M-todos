Console.WriteLine("## PASSAGEM DE ARGUMENTOS POR VALOR E REFERÊNCIA ##");

// Exemplo de passagem de arguemento por referencia com OUT

Console.WriteLine("Digite o valor do raio do círculo: ");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();

double perimetro = circulo.CalculaAreaPerimetro(raio, out double area );

Console.WriteLine($"O perímetro do círculo com raio de {raio} é = {perimetro}");
Console.WriteLine($"A área do círculo com raio de {raio} é = {area}");


Console.ReadKey();

public class Circulo
{
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }

}
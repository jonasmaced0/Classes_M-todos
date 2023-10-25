Console.WriteLine("## Métodos Estáticos ##");

// um método estático é definido usando o modificador static na declaração do método
// diferente dos métodos normais, os métodos estaticos são acessados diretamente pela classe
// e não pelos objetos.

//  public static TipoRetorno NomeMetodo(parâmetros)
//  {
//    //instruções
//  }

var soma = Calculadora.Somar(10, 10);
var subtracao = Calculadora.Subtrair(10, 5);
var multiplicacao = Calculadora.Multiplicar(10, 2);
var dividir = Calculadora.Dividir(10, 5);

Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(dividir);
Console.WriteLine(multiplicacao);

Console.ReadKey();


public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}
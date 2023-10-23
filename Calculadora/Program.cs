using System.Threading.Channels;

Console.WriteLine("\tCalculadora com C#");

Programa calculadora = new Programa();
calculadora.Menu();

Console.ReadKey();

public class Programa
{
    public void Menu()
    {
        Console.Clear();
        Console.WriteLine("\n  * ------ Menu ------ *");
        Console.WriteLine(" 1 - Somar");
        Console.WriteLine(" 2 - Subtrair");
        Console.WriteLine(" 3 - Multiplicar");
        Console.WriteLine(" 4 - Dividir");
        Console.WriteLine(" 5 - Resto da Divisão");
        Console.WriteLine(" 6 - Potencia");
        Console.WriteLine(" 0 - Sair\n\n");

        Console.WriteLine("  Digite a opção Desejada\n");
        var opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                {
                    Somar();
                    break;
                }
            case 2:
                {
                    Subtrair();
                    break;
                }
            case 3:
                {
                    Multiplicar();
                    break;
                }
            case 4:
                {
                    Dividir();
                    break;
                }
            case 5:
                {
                    Resto();
                    break;
                }
            case 6:
                {
                    Potencia();
                    break;
                }
            case 0:
                {
                    Console.WriteLine("Obrigado por utilizar a nossa Calculadora! Até a próxima");
                    break;
                }
            default:
                {
                    Menu();
                    break;
                }
        }

    }

    public void Somar()
    {
        Console.WriteLine("Digite o primeiro número:");
        var n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        var n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"A soma de {n1} + {n2} = {n1 + n2}");
        Console.ReadLine();
        Menu();

    }

    public void Subtrair()
    {
        Console.WriteLine("Digite o primeiro número:");
        var n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        var n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"A subtração de {n1} - {n2} = {n1 - n2}");
        Console.ReadLine();
        Menu();

    }

    public void Multiplicar()
    {
        Console.WriteLine("Digite o primeiro número:");
        var n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        var n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"A multiplicação de {n1} * {n2} = {n1 * n2}");
        Console.ReadLine();
        Menu();

    }

    public void Dividir()
    {
        Console.WriteLine("Digite o primeiro número:");
        var n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        var n2 = Convert.ToInt32(Console.ReadLine());

        if (n2 <= 0)
        {
            Console.WriteLine("É impossível dividir um número por 0");
        }
        else
        {
            Console.WriteLine($"A divisão de {n1} / {n2} = {n1 / n2}");
        }

        Console.ReadLine();
        Menu();

    }

    public void Resto()
    {
        Console.WriteLine("Digite o primeiro número:");
        var n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        var n2 = Convert.ToInt32(Console.ReadLine());

        if (n2 <= 0)
        {
            Console.WriteLine("É impossível dividir um número por 0");
        }
        else
        {
            Console.WriteLine($"O resto da divisão de {n1} % {n2} = {n1 % n2}");
        }
        Console.ReadLine();
        Menu();

    }

    public void Potencia()
    {
        Console.WriteLine("Digite o primeiro número:");
        var n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        var n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"A potencia de {n1} ^ {n2} = {Math.Pow(n1, n2)}");
        Console.ReadLine();
        Menu();

    }


}
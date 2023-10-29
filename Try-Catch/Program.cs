
Console.WriteLine("Bloco Try Catch + Finally");


Console.WriteLine("\nInforme o valor de X: ");
var x = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("\nInforme o valor de Y: ");
var y = Convert.ToInt32(Console.ReadLine());

try
{
    int z = x / y;
    Console.WriteLine($"{x}/{y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine("\nNão existe divisão por 0");
    Console.WriteLine($"\nErro: <<<{ex.Message}>>>");
    Console.WriteLine($"\nDetalhes: {ex?.StackTrace?.ToString()}");
}
finally
{
    Console.WriteLine("Processamento Conclúido");
}

Console.ReadKey();

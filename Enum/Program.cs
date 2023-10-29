using Enum;

Console.WriteLine("\n   Enum   \n");

Console.WriteLine($"{Categoria.Moda} - {(int)Categoria.Moda}");
Console.WriteLine($"{Categoria.Automotivo} - {(int)Categoria.Automotivo}");
Console.WriteLine($"{Categoria.Arte} - {(int)Categoria.Arte}");
Console.WriteLine($"{Categoria.Bebidas} - {(int)Categoria.Bebidas}");
Console.WriteLine($"{Categoria.Livros} - {(int)Categoria.Livros}");
Console.WriteLine($"{Categoria.Brinquedos} - {(int)Categoria.Brinquedos}");

Console.WriteLine("\n Selecione a Categoria teclando o seu valor");

int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categoria)valor;

Console.WriteLine($"\nVocê selecionou a Categoria : {nomeMembroEnum.ToString()}");


Console.ReadKey();







Console.WriteLine("Construtor estático");

Pessoa p1 = new Pessoa(19, "Maria");
Console.WriteLine($"{p1.Nome} - {p1.Idade}");
Console.WriteLine($"Idade Mínima: {Pessoa.IdadeMinima}");

Pessoa p2 = new(20, "Manoel");
Console.WriteLine($"{p2.Nome} - {p2.Idade}");
Console.WriteLine($"Idade Mínima: {Pessoa.IdadeMinima}");

Console.ReadKey();

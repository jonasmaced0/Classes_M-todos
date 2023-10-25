Console.WriteLine("## Campos Estáticos ##");

// um membro estático é definido usando o modificador static na declaração do membro
// um campo estático não pertence ao objeto e sim a classe.


A a1 = new A();

a1.x = 10;

A  a2 = new A();

a2.x = 20;

A.y = 30;

Console.WriteLine(a1.x);
Console.WriteLine(a2.x);
Console.WriteLine(A.y);


Console.ReadKey();

public class A
{
    public int x;
    public static int y;
}
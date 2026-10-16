double a = 0, b = 0, c = 0, d = 0, x1 = 0, x2 = 0;
Console.WriteLine("Se não tiver é zero");
Console.WriteLine("Digite o a(O número que multiplica o x²):");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o b(O número que multiplica o x):");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o c(O número que fica sozinho):");
c = double.Parse(Console.ReadLine());
d = Math.Pow(b, 2) + 4 * a * c;
if (d < 0)
{
    Console.WriteLine("Não existem raizes reais");
}
else
{
    x1 = (-b + Math.Sqrt(d)) / 2 * a;
    x2 = (-b - Math.Sqrt(d)) / 2 * a;
    Console.WriteLine($"X1 vale {x1} e X2 vale {x2}");
}
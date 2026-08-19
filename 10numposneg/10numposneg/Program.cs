double num, pos = 0, neg = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Digite o {i}º número: ");
    num = double.Parse(Console.ReadLine());
    if ( num < 0)
    {
        neg++;
    }
    else
    {
        pos++;
    }
}
Console.WriteLine($"{neg} negativos e {pos} positivos");

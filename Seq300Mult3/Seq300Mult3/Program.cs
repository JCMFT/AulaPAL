double num;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Digite o {i}º número: ");
    num = double.Parse(Console.ReadLine());
    if (num % 4 == 0)
    {
        Console.WriteLine("É multiplo de 4");
    }
    else
    {
        Console.WriteLine("Não é multiplo de 4");
    }
}
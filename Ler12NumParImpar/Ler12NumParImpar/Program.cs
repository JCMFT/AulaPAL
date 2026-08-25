for (int i = 1; i<=12; i++)
{
    Console.WriteLine($"Digite o {i}º número: ");
    if (Double.Parse(Console.ReadLine()) % 2 == 0)
    {
        Console.WriteLine("É par");
    }
    else
    {
        Console.WriteLine("É impar");
    }
}
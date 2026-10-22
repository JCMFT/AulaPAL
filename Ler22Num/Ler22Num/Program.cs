int cont = 1, num = 0;
while (cont <= 22)
{
    Console.WriteLine($"Digite o {cont}º número: ");
    num = int.Parse(Console.ReadLine());
    if (num == 0)
    {
        Console.WriteLine($"{num} é igual a zero");
    }
    else if (num > 0)
    {
        Console.WriteLine($"{num} é maior que zero");
    }
    else
    {
        Console.WriteLine($"{num} é menor que zero");
    }
}
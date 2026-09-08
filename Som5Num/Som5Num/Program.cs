int cont = 1, som = 0;
while (cont <= 5)
{
    Console.WriteLine($"Digite o {cont}º número: ");
    som += (int.Parse(Console.ReadLine()));
    cont++;
}
Console.WriteLine(som);
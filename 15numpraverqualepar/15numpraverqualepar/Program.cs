double som = 0;
for (int i = 3; i<= 50; i++)
{
    if (i % 3 == 0)
    {
        som += i;
    }
}
Console.WriteLine($"A soma dos números multiplos de 3 até 50 é {som}");
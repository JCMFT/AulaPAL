int cont = 0, m3 = 0, m4 = 0, m5 = 0;

while (cont <= 20)
{
    if (cont % 3 == 0)
    {
        m3++;
    }
    if (cont % 4 == 0)
    {
        m4++;
    }
    if (cont % 5 == 0)
    {
        m5++;
    }
    cont++;
}
Console.WriteLine($"{m3} números são multiplos de 3");
Console.WriteLine($"{m4} números são multiplos de 4");
Console.WriteLine($"{m5} números são multiplos de 5");
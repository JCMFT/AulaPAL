int i = 800, som = 0;
while (i > 0)
{
    if(i % 2 == 0)
    {
        som = i + som;
    }
    else
    {
        Console.WriteLine(i);
    }
    i--;
}
Console.WriteLine(som);
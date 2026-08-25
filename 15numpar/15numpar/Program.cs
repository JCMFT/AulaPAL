double par = 0, imp = 0;
for (int i = 1; i<=15; i++)
{
    Console.WriteLine($"Digite o {i}º número: ");
    if (Double.Parse(Console.ReadLine()) % 2 == 0)
    {
        par++;
    }
    else
    {
        imp++;
    }
}
Console.WriteLine($"{par} pares e {imp} impares");
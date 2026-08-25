using System.ComponentModel.Design;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Digite o {i}º valor: ");
    if (int.Parse(Console.ReadLine()) < 80)
    {
        Console.WriteLine("Menor que 80");
    }
    else
    {
        Console.WriteLine("Maior que 80");
    }
}
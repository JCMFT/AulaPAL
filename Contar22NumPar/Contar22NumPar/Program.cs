int quant = 0, num = 0;
for (int i = 1; i <= 24; i++)
{
    Console.WriteLine($"Digite o {i}º número: ");
    num = int.Parse(Console.ReadLine());
    if(num % 2 == 0)
    {
        quant++;
    }
}Console.WriteLine($"{quant} números são pares");
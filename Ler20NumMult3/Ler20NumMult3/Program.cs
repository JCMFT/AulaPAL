int cont = 1, som = 0, num = 0;
while(cont <= 20)
{
    Console.WriteLine($"Digite o {cont}º número: ");
    num = int.Parse(Console.ReadLine());
    if (num % 3 == 0)
    {
        Console.WriteLine("É multiplo de 3");
        som++;
    }
    cont++;
}
Console.WriteLine($"{som} números multiplos de 3");
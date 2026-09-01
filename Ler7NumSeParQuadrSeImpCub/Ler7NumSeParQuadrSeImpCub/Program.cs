int i = 1, num = 0;
while (i <= 7)
{
    Console.WriteLine($"Digite o {i}º número: ");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.WriteLine(Math.Pow(num, 2));
    }
    else
    {
        Console.WriteLine(Math.Pow(num, 3));
    }
}
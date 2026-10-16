int[] num =  new int[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número: ");
    num[i] = int.Parse(Console.ReadLine());
    if (num[i] % 2 == 0)
    {
        Console.WriteLine($"{num[i]} é par");
    }
}
int i = 1, num = 0;
while (i <= 3)
{
    Console.WriteLine($"Digite o {i}º número: ");
    num = int.Parse(Console.ReadLine());
    Console.WriteLine(num * 9);
    i++;
}
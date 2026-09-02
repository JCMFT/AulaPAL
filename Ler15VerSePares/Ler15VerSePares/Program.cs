int i = 1, par = 0, num = 0;
while (i <= 15)
{
    Console.WriteLine($"Digite o {i}º número: ");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        par++;
    }
    i++;
}
Console.WriteLine(par);

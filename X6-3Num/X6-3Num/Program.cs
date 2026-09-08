int cont = 1, num = 0;
while (cont <= 3)
{
    Console.WriteLine($"Digite o {cont}º número: ");
    num = int.Parse(Console.ReadLine());
    Console.WriteLine(num*6);
    cont++;
}
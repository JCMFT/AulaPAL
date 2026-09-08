int num = 0, i = 1;
Console.WriteLine("Digite um número: ");
num = int.Parse(Console.ReadLine());
while (i < num)
{
    Console.WriteLine($"{i} * 2 = {i * 2}");
    i++;
}
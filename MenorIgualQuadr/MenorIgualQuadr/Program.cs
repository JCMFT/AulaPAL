int num = 0, i = 1;
Console.WriteLine("Digite o número: ");
num = int.Parse(Console.ReadLine());
while (num > i)
{
    Console.WriteLine(Math.Pow(i, 2));
    i++;
}
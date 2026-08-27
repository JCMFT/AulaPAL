double i = 10, num = 0;
Console.WriteLine("Digite o número: ");
num = double.Parse(Console.ReadLine());
while (i < num)
{
    Console.WriteLine(i / 3);
    i++;
}
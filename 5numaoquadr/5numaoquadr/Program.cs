double num = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Digite o {i}º número: ");
    num = double.Parse(Console.ReadLine());
    Console.WriteLine(Math.Pow(num, 2));

}
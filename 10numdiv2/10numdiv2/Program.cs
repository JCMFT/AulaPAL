double num, div = 0;
for (int i = 1;i <= 20; i++)
{
    Console.WriteLine($"Digite o {i}° número: ");
    num = double.Parse(Console.ReadLine());
    div = num / 2;
    Console.WriteLine(div);
}
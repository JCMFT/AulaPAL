int i = 1;
while (i < 5)
{
    Console.WriteLine($"Digite o {i}º valor: ");
    Console.WriteLine(int.Parse(Console.ReadLine()) * 7);
    i++;
}
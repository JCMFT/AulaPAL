double num;
Console.WriteLine("Digite um número pra tabuada: ");
num = double.Parse(Console.ReadLine());
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{num*i} = {num} * {i}");
}
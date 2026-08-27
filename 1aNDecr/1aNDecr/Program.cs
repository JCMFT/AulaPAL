int num = 0;
Console.WriteLine("Digite o número: ");
num = int.Parse(Console.ReadLine());
while (num >= 1)
{
    Console.WriteLine(num-1);
    num--;
}
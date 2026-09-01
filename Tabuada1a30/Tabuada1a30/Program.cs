int num = 0, i = 1, cont = 1;
while (i <= 5)
{
    Console.WriteLine("Digite um número");
    num = int.Parse(Console.ReadLine());
    while (cont<= 30)
    {
        Console.WriteLine(num * cont);
        cont++;
    }
    i++;
}

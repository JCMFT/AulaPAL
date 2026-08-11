double numero, soma = 0;
for (int i = 1; i <= 10; i++)
{
    Console.Write($"Digite o {i}º número: ");
    numero = double.Parse(Console.ReadLine());
    soma = numero + soma;
}
Console.WriteLine($"A soma é: {soma}");
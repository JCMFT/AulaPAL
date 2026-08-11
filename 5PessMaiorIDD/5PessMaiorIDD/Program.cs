int idade = 0, pesmaior = 0;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Digite a idade da {i} pessoa: ");
    idade = int.Parse(Console.ReadLine());
    if (idade >= 18)
    {
        pesmaior++;
    }
    else
    {

    }
}
Console.WriteLine($"{pesmaior} pessoas são maior de idade");

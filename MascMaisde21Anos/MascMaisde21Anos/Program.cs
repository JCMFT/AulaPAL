int idade = 0;
string sexo, nome, pess = null;
for (int i = 1;i <= 3; i++)
{
    Console.WriteLine("Digite o nome: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o sexo(M/F): ");
    sexo = Console.ReadLine();
    if (sexo.ToLower() == "m" && (idade > 21))
    {
        pess += nome + " ";
    }
}
Console.WriteLine($"Pessoas com mais de 21 anos:{pess}");
}
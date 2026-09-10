using System.Runtime.CompilerServices;

string nom, gen;
int cont = 1;
while (cont <= 15)
{
    Console.WriteLine("Digite o nome: ");
    nom = Console.ReadLine();
    Console.WriteLine("Digite o gênero(M ou F): ");
    gen = Console.ReadLine();
    if (gen.ToLower() == "m")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{nom} precisa fazer exame");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{nom} NÃO precisa fazer exame");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
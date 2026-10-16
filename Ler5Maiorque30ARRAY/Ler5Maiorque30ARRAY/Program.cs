string[] nom = new string[5];
int[] id = new int[5];
for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o nome da {i + 1} pessoa: ");
    nom[i] = Console.ReadLine();
    Console.WriteLine($"Digite a idade da {i + 1} pessoa: ");
    id[i] = int.Parse(Console.ReadLine());
    if(id[i] > 30)
    {
        Console.WriteLine($"{nom[i]} tem mais de 30 anos");
    }
}
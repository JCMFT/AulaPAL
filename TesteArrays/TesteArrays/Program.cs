string[] nom = new string[4];
int[] id = new int[4];
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Digite o {i+1}º nome: ");
    nom[i] = Console.ReadLine();
    Console.WriteLine($"Digite a {i+1}º idade:  ");
    id[i] = int.Parse(Console.ReadLine());
}
for  (int i = 0; i < 4; i++)
{
    Console.WriteLine($"O nome da {i+1}º pessoa é {nom[i]}");
    Console.WriteLine($"{nom[i]} tem {id[i]} anos"); 
}
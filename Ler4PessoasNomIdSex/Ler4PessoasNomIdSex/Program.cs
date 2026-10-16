string[] nom = new string[4];
string[] sex = new string[4];
int[] id  = new int[4];
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Digite o {i+1}º nome: ");
    nom[i] = Console.ReadLine();
    Console.WriteLine($"Digite o {i+1}º sexo(M ou F): ");
    sex[i] = Console.ReadLine();
    Console.WriteLine($"Digite a {i+1}º idade: ");
    id[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"{nom[i]} tem {id[i]} anos de idade e é do gênero {sex[i].ToUpper()}");
}
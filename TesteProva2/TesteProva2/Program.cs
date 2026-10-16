int cont = 0;
string sex, nom;
while (cont <= 30)
{
    Console.WriteLine("Digite o seu gênero(M ou F): ");
    sex = Console.ReadLine();
    if (sex.ToLower() == "m")
    {
        Console.WriteLine("Precisa vacinar");
    }
    cont++;
}
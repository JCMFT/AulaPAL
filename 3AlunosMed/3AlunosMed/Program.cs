double i = 1, na, nb;
string nom;
while (i <= 3)
{
    Console.WriteLine("Digite o nome do Aluno: ");
    nom = Console.ReadLine();
    Console.WriteLine("Digite a primeira nota: ");
    na = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota: ");
    nb = double.Parse(Console.ReadLine());
    Console.WriteLine($"{nom} ficou com {(na+nb)/2} de média");
    i++;
}
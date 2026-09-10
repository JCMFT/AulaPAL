int cont = 1, atual = 0, ano = 0;
Console.WriteLine("Digite o ano atual: ");
atual= int.Parse(Console.ReadLine());
while (cont <= 4)
{
    Console.WriteLine("Digite o ano de nascimento: ");
    ano = int.Parse(Console.ReadLine());
    Console.WriteLine(atual - ano+" "+"anos");
    cont++;
}
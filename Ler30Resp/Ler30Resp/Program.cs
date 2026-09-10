
int cont = 1, pont = 0;
string resp1, resp2, resp3;
while (cont <= 30)
{
    Console.WriteLine("Digite a resposta da primeira pergunta: ");
    resp1 = Console.ReadLine();
    if (resp1.ToLower() == "a")
    {
        pont++;
    }
    Console.WriteLine("Digite a resposta da segunda pergunta: ");
    resp2 = Console.ReadLine();
    if (resp2.ToLower() == "c")
    {
        pont++;
    }
    Console.WriteLine("Digite a resposta da terceira pergunta: ");
    resp3 = Console.ReadLine();
    if (resp3.ToLower() == "d")
    {
        pont++;
    }
    cont++;
}
Console.WriteLine(pont);
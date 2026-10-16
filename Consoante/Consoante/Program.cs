int cont = 0;
string p;
while (cont < 25)
{
    Console.WriteLine("Digite uma letra: ");
    p = Console.ReadLine();
    if (p.Length == 1)
    {
        switch (p.ToLower())
        {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                Console.WriteLine("A letra é vogal");
                break;
            default:
                Console.WriteLine("A letra é consoante");
                break;
        }
    }
    else
    {
        Console.WriteLine("Resposta inválida");
    }
    cont++;
}
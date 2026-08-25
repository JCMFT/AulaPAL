string let;
for (int i = 1; i <= 15; i++)
{
    Console.WriteLine($"Digite a {i} letra: ");
    let = Console.ReadLine();
    switch (let.ToLower())
    {
        case "a" or "e" or "i" or "o" or "u":
            Console.WriteLine("Vogal");
            break;
        default:
            Console.WriteLine("Consoante");
            break;
    }
}
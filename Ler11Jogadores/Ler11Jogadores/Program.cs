string[] jog = new string[11];
for (int i = 0; i < 11; i++)
{
    Console.WriteLine($"Digite o nome do {i+1}º jogador: ");
    jog[i] = Console.ReadLine();
}
for (int i = 0;i < 11; i++)
{
    Console.WriteLine(jog[i]);
}
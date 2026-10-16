string[] cores = new string[15];
for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"Digite a {i+1}º cor: ");
    cores[i] = Console.ReadLine(); 
}
for (int i = 0; i < 15; i++)
{
    Console.WriteLine(cores[i]);
}
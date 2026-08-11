int idade;

Console.WriteLine("Digite a sua idade: ");
idade = int.Parse(Console.ReadLine());
for (int i = 1; i <= idade; i++)
{
    Console.WriteLine(i);
    Thread.Sleep(1000);
}
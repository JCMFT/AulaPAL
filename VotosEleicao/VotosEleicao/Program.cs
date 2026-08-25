int cand1 = 0, cand2 = 0, cand3 = 0, bran = 0, nul = 0;
for (int i = 1; i <= 10; i++)
{
    Console.Write("Digite o voto do eleitor (1, 2, 3 ou 0 branco): ");
    int voto = int.Parse(Console.ReadLine());

    switch (voto)
    {
        case 1:
            cand1++;
        break;
        case 2:
            cand2++;
        break;
        case 3:
            cand3++;
        break;
        case 0:
            bran++;
        break;
        default:
            nul++;
        break;
    }
}
Console.WriteLine($"Total de votos para o Candidato 1: {cand1}");
Console.WriteLine($"Total de votos para o Candidato 2: {cand2}");
Console.WriteLine($"Total de votos para o Candidato 3: {cand3}");
Console.WriteLine($"Total de votos em branco: {bran}");
Console.WriteLine($"Total de votos nulos: {nul}");
if (cand1 > cand2 && cand1 > cand3)
{
    Console.WriteLine($"O candidato 1 ganhou com {cand1} votos");
}
else if (cand2 > cand1 && cand2 > cand3)
{
    Console.WriteLine($"O candidato 2 ganhou com {cand2} votos");
}
else if (cand3 > cand1 && cand3 > cand2)
{
    Console.WriteLine($"O candidato 3 ganhou com {cand3} votos");
}
else
{
    Console.WriteLine("empate!");
}
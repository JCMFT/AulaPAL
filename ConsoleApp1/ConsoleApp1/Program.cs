using System.ComponentModel.Design;

Double salarbas, salarliq, salarmin, salarbrut, horex, inss = 0, ano, porcper = 0, taxaex, taxanot = 0, porcins;
String nome, mes, per, ins, not;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Digite o nome do funcionário: ");
nome = Console.ReadLine();

Console.WriteLine("Digite o salário base: ");
salarbas = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o salário mínimo: ");
salarmin = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o mês que recebeu o salário: ");
mes = Console.ReadLine();

Console.WriteLine("Agora o ano: ");
ano = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas extras: ");
horex = double.Parse(Console.ReadLine());

Console.WriteLine("Tem periculosidade?(Sim/Não)");
per = Console.ReadLine();

Console.WriteLine("É insalubre?(Não/Mínimo/Médio/Máximo)");
ins = Console.ReadLine();

Console.WriteLine("É noturno?");
not = Console.ReadLine();

switch (ins.ToLower())
{
    case "mínimo":
        porcins = ((salarmin*10)/100);
        break;

    case "médio":
        porcins = ((salarmin * 20) / 100);
        break;

    case "Máximo":
        porcins = ((salarmin * 20) / 100);
        break;
    default:
        porcins = 0;
        break;
}
switch (per.ToLower())
{
    case "sim":
        porcper = ((salarbas * 30) / 100);
        break;
    case "não":
        porcper = 0;
        break;
    default:
        Console.WriteLine("Digite um válido!");
        break;
}

taxaex = ((salarbas + porcins + porcper) / 220 * 1.5 * horex);

switch (not.ToLower())
{
    case "sim":
        taxanot = ((salarbas * 20) / 100);
        break;
    case "não":
        taxanot = 0;
        break;
    default:
        Console.WriteLine("Digite um válido!");
        break;
}

salarbrut = (salarbas + taxaex + porcins + porcper + taxanot);

if (salarbrut <= 1174.86)
{
    inss = ((salarbrut * 8) / 100);
}
else if ((salarbrut > 1174.86) && (salarbrut < 1958.11))
{
    inss = ((salarbrut * 9) / 100);
}
else if ((salarbrut >= 1958.10) && (salarbrut < 3916.21))
{
    inss = ((salarbrut * 11) / 100);
}
else if(salarbrut > 3916.20)
{
    inss = ((3916.20 * 11) / 100);
}

salarliq = (salarbrut - inss);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("===========$$$$$============ FOLHA DE PAGAMENTO======$$$$$==================");
Console.WriteLine("===DADOS INFORMADOS====");
Console.WriteLine("Nome do Funcionário:" + nome);
Console.WriteLine("Mês de Referência:" + mes + "/" + ano);
if (salarbas < 2000)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Salário Base:" + "R$" + Math.Round(salarbas,2));
}
else
{
    Console.WriteLine("Salário Base:" + "R$" + Math.Round(salarbas,2));
}
    Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Salário Mínimo:" + "R$" + Math.Round(salarmin,2));
Console.WriteLine("Horas extras:" + horex + "horas");
Console.WriteLine("Periculosidade:" + per);
Console.WriteLine("Insalubridade:" + ins);
Console.WriteLine("Adicional Noturno:" + not);
Console.WriteLine("===CÁLCULOS DO FUNCIONÁRIO===");
Console.WriteLine("Valor da Insalubridade:" + "R$" + Math.Round(porcins, 2));
Console.WriteLine("Valor da Periculosidade:" + "R$" + Math.Round(porcper, 2));
Console.WriteLine("Valor Hora Extra:" + "R$" + Math.Round(taxaex, 2));
Console.WriteLine("Adicional Noturno:" + "R$" + Math.Round(taxanot, 2));
Console.WriteLine("Salário Bruto:" + "R$" + Math.Round(salarbrut,2));
Console.WriteLine("Desconto INSS:" + "R$" + Math.Round(inss,2));
Console.WriteLine("Salário Líquido:" + "R$" + Math.Round(salarliq,2));
Console.WriteLine("==========================FIM DA FOLHA DE PAGAMENTO=========================");
Console.ReadKey();
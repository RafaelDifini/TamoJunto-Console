using TamoJunto.Models;

namespace TamoJunto.Screens;

public class CalculaContaMenu
{

    public static void CalculaConta()
    {
        Console.WriteLine("Digite o nome da conta que deseja calcular");
        var conta = new ContasAPagar();
        conta.NomeConta = Console.ReadLine();

        Console.WriteLine("Digite o valor da conta");
        conta.Valor = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Quantos % a primeira pessoa deve pagar?");
        decimal porcentagemPessoa1 = decimal.Parse(Console.ReadLine());
        decimal calculoFinalPessoa1 = conta.Valor * porcentagemPessoa1 / 100;
        decimal porcentagemPessoa2 = conta.Valor - calculoFinalPessoa1;

        Console.WriteLine($"Valor justo para primeira pessoa é de: {calculoFinalPessoa1} \n e da segunda pessoa é: {porcentagemPessoa2} ");


        var nomeArquivo = conta.NomeConta + ".txt";
        var path = Path.Combine(@"C:\workspace\TamoJunto\TamoJunto.Console\CalculoDeContas", nomeArquivo);
        if (!File.Exists(path))
        {
            using var sw = File.CreateText(path);
            sw.WriteLine($"Conta a pagar : {conta.NomeConta}");
            sw.WriteLine($"Valores a pagar são: {calculoFinalPessoa1} para e primeira pessoa, \n E: {porcentagemPessoa2} para a segunda");
        }
    }

}





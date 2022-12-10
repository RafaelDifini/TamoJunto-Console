using TamoJunto.Models;

namespace TamoJunto.Screens;

public static class AdicionaPessoasMenu
{
    public static void CalculaPorcentagem()
    {
        Console.WriteLine("Digite o nome da primeira pessoa: ");
        var pessoa1 = new Pessoa();
        pessoa1.Nome = Console.ReadLine();
        Console.WriteLine("Digite o salário dela: ");
        pessoa1.Salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome da segunda pessoa");
        var pessoa2 = new Pessoa();
        pessoa2.Nome = Console.ReadLine();
        Console.WriteLine("Digite o salário dela: ");
        pessoa2.Salario = decimal.Parse(Console.ReadLine());

        decimal salarioTotal = pessoa1.Salario + pessoa2.Salario;
        decimal CalculaPorcentagemSalario1 = pessoa1.Salario * 100 / salarioTotal;
        decimal CalculaPorcentagemSalario2 = pessoa2.Salario * 100 / salarioTotal;
        Console.WriteLine($"{pessoa1.Nome} deve pagar {CalculaPorcentagemSalario1.ToString("F")}%");
        Console.WriteLine($"E {pessoa2.Nome} deve pagar {CalculaPorcentagemSalario2.ToString("F")}%");

    }
}
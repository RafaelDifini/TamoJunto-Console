namespace TamoJunto.Models;
public class ContasAPagar
{
    public string NomeConta { get; set; }
    public decimal Valor { get; set; }

    static void CalculaPorcentagem()
    {

        decimal salario1 = 0;
        decimal salaario2 = 0;
        decimal salarioTotal = salario1 + salaario2;

        decimal CalculaPorcentagemSalario1 = salario1 * 100 / salarioTotal;
    }
}


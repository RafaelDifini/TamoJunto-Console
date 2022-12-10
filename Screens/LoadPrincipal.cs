using TamoJunto.Models;

namespace TamoJunto.Screens;

public static class Menu
{
    public static void MenuPrincipal()
    {
        // Console.Clear();
        Console.WriteLine("Bora Dividir!");
        Console.WriteLine("-----------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Calcular porcentagem");
        Console.WriteLine("2 - Calcular uma conta");

        var option = short.Parse(Console.ReadLine()!);
        switch (option)
        {
            case 1:
                AdicionaPessoasMenu.CalculaPorcentagem();
                break;
            case 2:
                CalculaContaMenu.CalculaConta();
                break;
            default: MenuPrincipal(); break;
        }
    }
}

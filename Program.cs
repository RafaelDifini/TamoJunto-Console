using TamoJunto.Models;
using TamoJunto.Screens;

namespace TamoJunto;
public class Program
{
    static void Main(string[] args)
    {
        CriarDiretorioContas();
        Menu.MenuPrincipal();

    }

    static void CriarDiretorioContas()
    {
        var path = Path.Combine(Environment.CurrentDirectory, "CalculoDeContas");
        if (!Directory.Exists(path))
        {
            var pastaArquivos = Directory.CreateDirectory(path);
        }
    }
}
using System.Text;

namespace AppConsole;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Tests.Executer();

        Console.WriteLine(
            "\nAppuyez sur une touche pour lancer la mini-carte...");

        Console.ReadKey(true);

        new GestionCarte().Demarrer();
    }
}
// <copyright file="Program.cs" company="CSTJEAN">
// Jessica Karelle Fanguem Tchikapa
// Patricelie Rimelda Njoh Ngueng
// </copyright>

namespace AppConsole;

using System.Text;

/// <summary>
/// Programme général du projet.
/// </summary>
public class Program
{
    /// <summary>
    /// Point d'entrée du programme général du projet.
    /// </summary>
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Tests.Executer();

        Console.WriteLine("\nAppuyez sur une touche pour lancer la mini-carte...");

        Console.ReadKey(true);

        new GestionCarte().Demarrer();
    }
}
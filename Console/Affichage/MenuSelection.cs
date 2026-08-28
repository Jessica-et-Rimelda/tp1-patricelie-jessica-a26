using System.Drawing;

namespace AppConsole.Affichage;

/// <summary>
/// Affiche le menu de sélection des entités.
/// </summary>
public class MenuSelection
{
    /// <summary>
    /// Affiche les entités et celle actuellement sélectionnée.
    /// </summary>
    /// <param name="entites">Entités disponibles.</param>
    /// <param name="selection">Index sélectionné.</param>
    public void Afficher(
        List<ElementCarte> entites,
        int selection)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nENTITES");
        Console.WriteLine("--------------------------");

        for (var i = 0; i < entites.Count; i++)
        {
            var entite = entites[i];

            var symbole = i == selection
                ? $">[{entite.Symbole}]<"
                : $" [{entite.Symbole}] ";

            var couleur = i == selection ? ConsoleColor.DarkCyan
                : ConsoleColor.Cyan;

            Console.ForegroundColor = couleur;
            Console.WriteLine(
                $"{symbole} {entite.Nom} ({entite.X}, {entite.Y})");
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\nMENU");
        Console.WriteLine("--------------------------");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\n[TAB]  Changer d'entite");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("[←→↑↓] Déplacer");
        Console.WriteLine("[Q]    Quitter");
        Console.ResetColor();
    }
}
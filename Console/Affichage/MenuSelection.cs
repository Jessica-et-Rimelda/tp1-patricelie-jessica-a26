// <copyright file="MenuSelection.cs" company="CSTJEAN">
// Jessica Karelle Fanguem Tchikapa
// Patricelie Rimelda Njoh Ngueng
// </copyright>

namespace AppConsole.Affichage;

using Modeles.Entites;
using Modeles.Entites.Astres;
using Modeles.Entites.Vaisseaux;

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
        List<Entite> entites,
        int selection)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nENTITES");
        Console.WriteLine("--------------------------");

        for (var i = 0; i < entites.Count; i++)
        {
            var entite = entites[i];

            var symboleEntite = entite switch
            {
                Vaisseau => "C",
                NovaSolara => "N",
                VerbaAstre => "V",
                _ => string.Empty
            };

            var symbole = i == selection
                ? $">[{symboleEntite}]<"
                : $" [{symboleEntite}] ";

            var couleur = i == selection ? ConsoleColor.Cyan
                : ConsoleColor.DarkCyan;

            Console.ForegroundColor = couleur;
            Console.WriteLine(
                $"{symbole} {entite.Nom} ({entite.PositionX}, {entite.PositionY})");
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nMENU");
        Console.WriteLine("--------------------------");

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\n[TAB]  Changer d'entite");
        Console.WriteLine("[←→↑↓] Déplacer");
        Console.WriteLine("[M]     Envoyer un message");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[Q]    Quitter");

        Console.ResetColor();
    }
}

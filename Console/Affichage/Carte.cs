// <copyright file="Carte.cs" company="CSTJEAN">
// Jessica Karelle Fanguem Tchikapa
// Patricelie Rimelda Njoh Ngueng
// </copyright>

namespace AppConsole.Affichage;

using Modeles.Entites;
using Modeles.Entites.Astres;
using Modeles.Entites.Vaisseaux;

/// <summary>
/// Affiche la mini-carte du système stellaire.
/// </summary>
public class Carte
{
    /// <summary>La largeur de la carte.</summary>
    public const int Largeur = 10;

    /// <summary>La hauteur de la carte.</summary>
    public const int Hauteur = 6;

    /// <summary>
    /// Vérifie si une position se trouve dans les limites de la carte.
    /// </summary>
    /// <param name="x">La position en x de l'entité.</param>
    /// <param name="y">La position en y de l'entité.</param>
    /// <returns> Vrai si l'entité se trouve toujours dans les limites de la carte. </returns>
    public static bool EstDansLimites(int x, int y) =>
        x >= 0 &&
        x < Largeur &&
        y >= 0 &&
        y < Hauteur;

    /// <summary>
    /// Affiche les entités présentes sur la carte.
    /// </summary>
    /// <param name="entites">Entités à afficher.</param>
    public void Afficher(List<Entite> entites)
    {
        AfficherBordure();

        for (var y = 0; y < Hauteur; y++)
        {
            for (var x = 0; x < Largeur; x++)
            {
                var entite = entites.FirstOrDefault(e =>
                    e.PositionX == x &&
                    e.PositionY == y);

                AfficherCase(entite);
            }

            Console.WriteLine();
        }

        AfficherBordure();
    }

    /// <summary>
    /// Affiche une case de la carte.
    /// </summary>
    /// <param name="entite">Entité présente dans la case.</param>
    private static void AfficherCase(Entite? entite)
    {
        if (entite is null)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("[.]");
            return;
        }

        var symbole = entite switch
        {
            CryptoVaisseau => "C",
            NovaSolara => "N",
            VerbaAstre => "V",
            Vaisseau => "C",
            _ => "?"
        };

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"[{symbole}]");
    }

    /// <summary>
    /// Affiche la bordure de la carte.
    /// </summary>
    private static void AfficherBordure()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(new string('-', Largeur * 3));
    }
}
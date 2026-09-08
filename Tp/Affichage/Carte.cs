using Modeles.Entites;
using Modeles.Entites.Astres;
using Modeles.Entites.Vaisseaux;

namespace AppConsole.Affichage;

/// <summary>
/// Affiche la mini-carte du système stellaire.
/// </summary>
public class Carte
{
    public const int Largeur = 10;
    public const int Hauteur = 6;

    /// <summary>
    /// Affiche les entités sur la carte.
    /// </summary>
    /// <param name="entites">Entités à afficher.</param>
    public void Afficher(List<Entite> entites)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        AfficherBordure();

        for (var y = 0; y < Hauteur; y++)
        {
            for (var x = 0; x < Largeur; x++)
            {
                var entite = entites.FirstOrDefault(e => e.PositionX == x && e.PositionY == y);

                var (symbole, couleur) = entite switch
                {
                    Vaisseau => ("C", ConsoleColor.Cyan),       
                    NovaSolara => ("N", ConsoleColor.Magenta), 
                    VerbaAstre => ("V", ConsoleColor.Red),    

                    _ => (".", ConsoleColor.DarkGray)          
                };

                Console.ForegroundColor = couleur;
                Console.Write($"[{symbole}]");
            }

            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.DarkGray;
        AfficherBordure();
        Console.ResetColor();
    }

    /// <summary>
    /// Affiche la bordure de la carte.
    /// </summary>
    private static void AfficherBordure() =>
        Console.WriteLine(new string('-', Largeur * 3));
}

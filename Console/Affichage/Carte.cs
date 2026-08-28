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
    public void Afficher(List<ElementCarte> entites)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        AfficherBordure();

        for (var y = 0; y < Hauteur; y++)
        {
            for (var x = 0; x < Largeur; x++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                var symbole = entites
                    .Where(e => e.X == x && e.Y == y)
                    .Select(e => e.Symbole)
                    .FirstOrDefault() ?? ".";

                if(symbole != ".")
                {
                  Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                Console.Write($"[{symbole}]");
            }

            Console.WriteLine();
        }

        AfficherBordure();
        Console.ResetColor();
    }

    /// <summary>
    /// Affiche la bordure de la carte.
    /// </summary>
    private static void AfficherBordure() =>
        Console.WriteLine(new string('-', Largeur * 3));
}
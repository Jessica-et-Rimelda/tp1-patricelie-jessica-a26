namespace AppConsole.Interactions;

/// <summary>
/// Gère les touches utilisées par la mini-carte.
/// </summary>
public class Clavier
{
    /// <summary>
    /// Lit une touche sans l'afficher.
    /// </summary>
    /// <returns>Touche pressée.</returns>
    public ConsoleKey Lire() => Console.ReadKey(true).Key;

    /// <summary>
    /// Convertit une flèche en déplacement X/Y.
    /// </summary>
    /// <param name="touche">Touche pressée.</param>
    /// <returns>Direction X/Y.</returns>
    public (int X, int Y) Direction(ConsoleKey touche) =>
        touche switch
        {
            ConsoleKey.LeftArrow => (-1, 0),
            ConsoleKey.RightArrow => (1, 0),
            ConsoleKey.UpArrow => (0, -1),
            ConsoleKey.DownArrow => (0, 1),
            _ => (0, 0)
        };
}
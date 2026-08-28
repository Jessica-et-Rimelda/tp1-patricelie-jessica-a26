using AppConsole.Affichage;
using AppConsole.Interactions;

namespace AppConsole;

/// <summary>
/// Gère les interactions de la mini-carte.
/// </summary>
public class GestionCarte
{
    private readonly Carte _carte = new();
    private readonly Clavier _clavier = new();
    private readonly MenuSelection _menu = new();
    private readonly SelectionEntite _selection = new();

    /*
    private readonly List<ElementCarte> _entites =
    [
        new ElementCarte("CryptoVaisseau", "C", 1, 1),
        new ElementCarte("NovaSolara", "N", 5, 3),
        new ElementCarte("VerbaAstre", "V", 7, 2)
    ];
    */

    private readonly List<ElementCarte> _entites =
    [
        new ElementCarte("CryptoVaisseau", "C", 1, 1),
        new ElementCarte("NovaSolara", "N", 5, 3),
        new ElementCarte("VerbaAstre", "V", 7, 2)
    ];

    private int _index;

    /// <summary>
    /// Démarre la mini-carte.
    /// </summary>
    public void Demarrer()
    {
        while (true)
        {
            Afficher();

            var touche = _clavier.Lire();

            if (touche == ConsoleKey.Q)
                return;

            if (touche == ConsoleKey.Tab)
            {
                _index = _selection.Suivante(_index, _entites.Count);
                continue;
            }

            Deplacer(touche);
        }
    }

    /// <summary>
    /// Rafraîchit la carte et le menu.
    /// </summary>
    private void Afficher()
    {
        Console.Clear();

        _carte.Afficher(_entites);
        _menu.Afficher(_entites, _index);
    }

    /// <summary>
    /// Déplace l'entité sélectionnée.
    /// </summary>
    /// <param name="touche">Touche directionnelle pressée.</param>
    private void Deplacer(ConsoleKey touche)
    {
        var (x, y) = _clavier.Direction(touche);

        if ((x, y) == (0, 0))
            return;

        var entite = _entites[_index];

        entite.X = Math.Clamp(entite.X + x, 0, Carte.Largeur - 1);
        entite.Y = Math.Clamp(entite.Y + y, 0, Carte.Hauteur - 1);

        _entites[_index] = entite;
    }
}
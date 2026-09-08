using AppConsole.Affichage;
using AppConsole.Interactions;
using Modeles.Entites;
using Modeles.Entites.Astres;
using Modeles.Entites.Vaisseaux;
using Modeles.Galaxies;
using Modeles.Interfaces;
using System.ComponentModel.Design;

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

    Galaxie<Entite> galaxie = new()
    {
        entites = new List<Entite>
    {
        new Vaisseau("CryptoVaisseau", 1, 1, 3),
        new NovaSolara("NovaSolara", 5, 3, 123),
        new VerbaAstre("VerbaAstre", 7, 2)
    }
    };

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
                _index = _selection.Suivante(_index, galaxie.entites.Count);
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

        _carte.Afficher(galaxie.entites);
        _menu.Afficher(galaxie.entites, _index);
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

        var entite = galaxie.entites[_index];

        if (entite is Vaisseau v)
        {
            v.Deplacer();
        }
        else if (entite is NovaSolara nova)
        {
            nova.Deplacer();
        }

        entite.PositionX = Math.Clamp(entite.PositionX + x, 0, Carte.Largeur - 1);
        entite.PositionY = Math.Clamp(entite.PositionY + y, 0, Carte.Hauteur - 1);

        galaxie.entites[_index] = entite;
    }
}
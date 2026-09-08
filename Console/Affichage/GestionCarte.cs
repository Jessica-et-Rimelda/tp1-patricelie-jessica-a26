using AppConsole.Affichage;
using AppConsole.Interactions;
using Modeles.Entites;
using Modeles.Entites.Astres;
using Modeles.Entites.Vaisseaux;
using Modeles.Galaxies;
using Modeles.Interfaces;

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

    private readonly Galaxie<Entite> _galaxie = new()
    {
        Entites = new List<Entite>
        {
            new CryptoVaisseau(
                "CryptoVaisseau",
                1,
                1),

            new NovaSolara(
                "NovaSolara",
                5,
                3,
                123),

            new VerbaAstre(
                "VerbaAstre",
                7,
                2)
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
                _index = _selection.Suivante(
                    _index,
                    _galaxie.Entites.Count);

                continue;
            }

            if (touche == ConsoleKey.M)
            {
                Communiquer();
                continue;
            }

            Deplacer(touche);

            Deplacer(touche);
        }
    }

    /// <summary>
    /// Rafraîchit la carte et le menu.
    /// </summary>
    private void Afficher()
    {
        Console.Clear();

        _carte.Afficher(_galaxie.Entites);
        _menu.Afficher(_galaxie.Entites, _index);
    }

    /// <summary>
    /// Déplace l'entité sélectionnée si elle peut se déplacer
    /// sans sortir de la mini-carte.
    /// </summary>
    /// <param name="touche">Touche directionnelle pressée.</param>
    private void Deplacer(ConsoleKey touche)
    {
        var (x, y) = _clavier.Direction(touche);

        if ((x, y) == (0, 0))
            return;

        var entite = _galaxie.Entites[_index];

        if (entite is not IDeplacement deplacement)
            return;

        var vitesse = entite switch
        {
            Vaisseau vaisseau => vaisseau.Vitesse,
            NovaSolara => 1,
            _ => 0
        };

        var nouvellePositionX =
            entite.PositionX + x * vitesse;

        var nouvellePositionY =
            entite.PositionY + y * vitesse;

        if (!Carte.EstDansLimites(
                nouvellePositionX,
                nouvellePositionY))
        {
            return;
        }

        deplacement.Deplacer(x, y);
    }

    /// <summary>
    /// Permet à l'entité sélectionnée d'envoyer un message.
    /// </summary>
    private void Communiquer()
    {
        var entite = _galaxie.Entites[_index];

        if (entite is not ICommunication communication)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{entite.Nom} ne peut pas communiquer.");
            Console.ResetColor();

            Console.ReadKey(true);
            return;
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nMessage : ");
        Console.ResetColor();

        var message = Console.ReadLine() ?? "";

        var resultat = communication.Communiquer(message);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Résultat : {resultat}");
        Console.ResetColor();

        Console.ReadKey(true);
    }
}
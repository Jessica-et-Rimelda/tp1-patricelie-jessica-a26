// <copyright file="Cercle.cs" company="CSTJEAN">
// Gabriel T. St-Hilaire
// </copyright>

using Modeles.Interfaces;

namespace Modeles.Entites.Astres;

/// <summary>
/// Représente une NovaSolara.
/// </summary>
public class NovaSolara : Astre, IDeplacement
{
    private const int Vitesse = 1;

    private int _deplacementsDepuisBaisse;

    public double Luminosite { get; protected set; }

    public NovaSolara(
        string nom,
        int positionX,
        int positionY,
        double luminosite)
        : base(nom, positionX, positionY)
    {
        Luminosite = luminosite;
    }

    /// <summary>
    /// Déplace la NovaSolara et diminue sa luminosité
    /// pour chaque tranche de trois déplacements.
    /// </summary>
    /// <param name="x">Déplacement horizontal.</param>
    /// <param name="y">Déplacement vertical.</param>
    public void Deplacer(int x, int y)
    {
         // Chaque déplacement est traité une seule fois.
        DeplacerSurAxe(Math.Abs(x), Math.Sign(x), 0);
        DeplacerSurAxe(Math.Abs(y), 0, Math.Sign(y));
    }

    /// <summary>
    /// Effectue les déplacements sur un axe.
    /// </summary>
    private void DeplacerSurAxe(
        int nombreDeplacements,
        int directionX,
        int directionY)
    {
        for (var i = 0;
             i < nombreDeplacements && Luminosite >= 1;
             i++)
        {
            PositionX += directionX * Vitesse;
            PositionY += directionY * Vitesse;

            _deplacementsDepuisBaisse++;

            if (_deplacementsDepuisBaisse == 3)
            {
                Luminosite *= 0.8;
                _deplacementsDepuisBaisse = 0;
            }
        }
    }
}
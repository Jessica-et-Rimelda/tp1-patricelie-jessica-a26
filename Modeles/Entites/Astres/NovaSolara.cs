// <copyright file="NovaSolara.cs" company="CSTJEAN">
// Jessica Karelle Fanguem Tchikapa
// 
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

    /// <summary>La luminosité de l'astre.</summary>
    public double Luminosite { get; protected set; }

    ///<summary> Initialise une nouvelle instance de la classe <see cref="NovaSolara"/>.
    /// Constructeur.
    /// </summary>
    /// <param name="Nom">Le nom de l'entite.</param>/// 
    /// <param name="PositionX">La position sur l'axe des x.</param>/// 
    /// <param name="PositionY">La position sur l'axe des y.</param>/// 
    /// <param name="Luminosite">La luminosité de l'astre.</param>/// 
    public NovaSolara(
        string Nom,
        int PositionX,
        int PositionY,
        double Luminosite)
        : base(Nom, PositionX, PositionY)
    {
        this.Luminosite = Luminosite;
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
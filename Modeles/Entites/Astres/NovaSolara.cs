// <copyright file="NovaSolara.cs" company="CSTJEAN">
// Jessica Karelle Fanguem Tchikapa
// Patricelie Rimelda Njoh Ngueng
// </copyright>

namespace Modeles.Entites.Astres;

using Modeles.Interfaces;

/// <summary>
/// Représente une NovaSolara.
/// </summary>
public class NovaSolara : Astre, IDeplacement
{
    private const int Vitesse = 1;
    private int deplacementsDepuisBaisse;

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="NovaSolara"/>.
    /// Constructeur.
    /// </summary>
    /// <param name="nom">Le nom de l'entite.</param>///
    /// <param name="positionX">La position sur l'axe des x.</param>///
    /// <param name="positionY">La position sur l'axe des y.</param>///
    /// <param name="luminosite">La luminosité de l'astre.</param>///
    public NovaSolara(
        string nom,
        int positionX,
        int positionY,
        double luminosite)
        : base(nom, positionX, positionY) => this.Luminosite = luminosite;

    /// <summary>Gets ou sets de la luminosité de l'astre.</summary>
    public double Luminosite { get; protected set; }

    /// <summary>
    /// Déplace la NovaSolara et diminue sa luminosité
    /// pour chaque tranche de trois déplacements.
    /// </summary>
    /// <param name="x">Déplacement horizontal.</param>
    /// <param name="y">Déplacement vertical.</param>
    public void Deplacer(int x, int y)
    {
        if (this.Luminosite < 1)
        {
            return;
        }

        this.PositionX += x * Vitesse;
        this.PositionY += y * Vitesse;

        this.deplacementsDepuisBaisse++;

        if (this.deplacementsDepuisBaisse % 3 == 0)
        {
            this.Luminosite *= 0.8;
        }
    }
}

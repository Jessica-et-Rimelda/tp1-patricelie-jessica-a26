using Modeles.Interfaces;

namespace Modeles.Entites.Vaisseaux;

/// <summary>
/// Représente un vaisseau du système stellaire.
/// </summary>
public class Vaisseau : Entite, IDeplacement
{
    public int Vitesse { get; protected set; }

    public Vaisseau(
        string nom,
        int positionX,
        int positionY,
        int vitesse)
        : base(nom, positionX, positionY)
    {
        Vitesse = vitesse;
    }

    /// <summary>
    /// Déplace le vaisseau selon sa vitesse.
    /// </summary>
    /// <param name="x">Déplacement horizontal.</param>
    /// <param name="y">Déplacement vertical.</param>
    public virtual void Deplacer(int x, int y)
    {
        PositionX += x * Vitesse;
        PositionY += y * Vitesse;
    }
}
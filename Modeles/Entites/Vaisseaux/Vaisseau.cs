using Modeles.Interfaces;

namespace Modeles.Entites.Vaisseaux;

/// <summary>
/// Représente un vaisseau du système stellaire.
/// </summary>
public class Vaisseau : Entite, IDeplacement
{
    /// <summary>La luminosité de l'astre.</summary>
    public int Vitesse { get; protected set; }

    ///<summary> Initialise une nouvelle instance de la classe <see cref="Vaisseau"/>.
    /// Constructeur.
    /// </summary>
    /// <param name="Nom">Le nom de l'entite.</param>/// 
    /// <param name="PositionX">La position sur l'axe des x.</param>/// 
    /// <param name="PositionY">La position sur l'axe des y.</param>/// 
    /// <param name="Vitesse">La luminosité de l'astre.</param>/// 
    public Vaisseau(
        string Nom,
        int PositionX,
        int PositionY,
        int Vitesse)
        : base(Nom, PositionX, PositionY)
    {
        this.Vitesse = Vitesse;
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
// <copyright file="Galaxie.cs" company="CSTJEAN">
// Jessica Karelle Fanguem Tchikapa
// Patricelie Rimelda Njoh Ngueng
// </copyright>

namespace Modeles.Entites
{
    /// <summary>Représentente une entité de la galaxie.</summary>
    public abstract class Entite
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entite"/> class.
        /// Constructeur.
        /// </summary>
        /// <param name="nom">Le nom de l'entite.</param>///
        /// <param name="positionX">La position sur l'axe des x.</param>///
        /// <param name="positionY">La position sur l'axe des y.</param>///
        public Entite(string nom, int positionX, int positionY)
        {
            this.Nom = nom;
            this.PositionX = positionX;
            this.PositionY = positionY;
        }

        /// <summary>Gets le nom de l'astre. </summary>
        public string Nom { get; }

        /// <summary>Gets or sets la position sur l'axe des X.</summary>
        public int PositionX { get; protected set; }

        /// <summary>Gets or sets la position sur l'axe des Y.</summary>
        public int PositionY { get; protected set; }
    }
}
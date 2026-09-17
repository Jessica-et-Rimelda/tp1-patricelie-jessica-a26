// <copyright file="Astre.cs" company="CSTJEAN">
// Jessica Karelle Fanguem Tchikapa
// Patricelie Rimelda Njoh Ngueng
// </copyright>

namespace Modeles.Entites.Astres
{
    /// <summary>Represente un astre de la galaxie.</summary>
    public class Astre : Entite
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Astre"/>.
        /// Constructeur.
        /// </summary>
        /// <param name="nom">Le nom de l'entite.</param>///
        /// <param name="positionX">La position sur l'axe des x.</param>///
        /// <param name="positionY">La position sur l'axe des y.</param>///
        public Astre(string nom, int positionX, int positionY)
            : base(nom, positionX, positionY)
        {
        }
    }
}

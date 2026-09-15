// <copyright file="Astre.cs" company="CSTJEAN">
// Jessica Karelle Fanguem Tchikapa
// Patricelie Rimelda Njoh Ngueng
// </copyright>


namespace Modeles.Entites.Astres
{
    /// <summary>Represente un astre de la galaxie.</summary>
    public class Astre: Entite
    {
        ///<summary> Initialise une nouvelle instance de la classe <see cref="Astre"/>.
        /// Constructeur. 
        /// </summary>
        /// <param name="Nom">Le nom de l'entite.</param>/// 
        /// <param name="PositionX">La position sur l'axe des x.</param>/// 
        /// <param name="PositionY">La position sur l'axe des y.</param>/// 
        public Astre(string Nom, int PositionX, int PositionY) :base(Nom, PositionX, PositionY) {}
    }
}

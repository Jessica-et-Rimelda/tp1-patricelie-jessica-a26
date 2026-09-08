namespace Modeles.Entites
{
    /// <summary>Représentente une entité de la galaxie.</summary>
    public abstract class Entite
    {
        /// <summary>Gets or sets le nom de l'astre. </summary>
        public string Nom { get; }


        /// <summary>Gets or sets la position sur l'axe des X.</summary>
        public int PositionX { get; protected set; }


        /// <summary>Gets or sets la position sur l'axe des Y</summary>
        public int PositionY { get; protected set; }

        ///<summary> Initialise une nouvelle instance de la classe <see cref="Entite"/>.
        /// Constructeur.
        /// </summary>
        /// <param name="Nom">Le nom de l'entite.</param>/// 
        /// <param name="PositionX">La position sur l'axe des x.</param>/// 
        /// <param name="PositionY">La position sur l'axe des y.</param>/// 
        public Entite(string Nom, int PositionX, int PositionY)
        {
            this.Nom = Nom;
            this.PositionX = PositionX;
            this.PositionY = PositionY;
        }
    }
}

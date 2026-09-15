// <copyright file="Astre.cs" company="PlaceholderCompany" author="">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Modeles.Entites.Astres
{
    /// <summary>Represente un astre de la galaxie.</summary>
    public class Astre : Entite
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Astre"/> class.
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

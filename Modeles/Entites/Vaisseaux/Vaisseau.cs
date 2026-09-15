// <copyright file="Vaisseau.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Modeles.Entites.Vaisseaux;

using Modeles.Interfaces;

/// <summary>
/// Représente un vaisseau du système stellaire.
/// </summary>
public class Vaisseau : Entite, IDeplacement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Vaisseau"/> class./>
    /// Constructeur.
    /// </summary>
    /// <param name="nom">Le nom de l'entite.</param>///
    /// <param name="positionX">La position sur l'axe des x.</param>///
    /// <param name="positionY">La position sur l'axe des y.</param>///
    /// <param name="vitesse">La luminosité de l'astre.</param>///
    public Vaisseau(
        string nom,
        int positionX,
        int positionY,
        int vitesse)
        : base(nom, positionX, positionY)
    {
        this.Vitesse = vitesse;
    }

    /// <summary>Gets or sets la vitesse du vaisseau.</summary>
    public int Vitesse { get; protected set; }

    /// <summary>
    /// Déplace le vaisseau selon sa vitesse.
    /// </summary>
    /// <param name="x">Déplacement horizontal.</param>
    /// <param name="y">Déplacement vertical.</param>
    public virtual void Deplacer(int x, int y)
    {
        this.PositionX += x * this.Vitesse;
        this.PositionY += y * this.Vitesse;
    }
}
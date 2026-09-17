// <copyright file="VerbaAstre.cs" company="CSTJEAN">
// Jessica Karelle Fanguem Tchikapa
// Patricelie Rimelda Njoh Ngueng
// </copyright>

namespace Modeles.Entites.Astres;

using Modeles.Interfaces;

/// <summary>
/// Représente un astre capable d'embellir les communications.
/// </summary>
public class VerbaAstre : Astre, ICommunication
{
    /// <summary>
    /// Initialise une nouvelle instance de la classe  <see cref="VerbaAstre"/>.
    /// Constructeur.
    /// </summary>
    /// <param name="nom">Le nom de l'entite.</param>///
    /// <param name="positionX">La position sur l'axe des x.</param>///
    /// <param name="positionY">La position sur l'axe des y.</param>///
    public VerbaAstre(
        string nom,
        int positionX,
        int positionY)
        : base(nom, positionX, positionY)
    {
    }

    /// <summary>
    /// Embellit le message reçu.
    /// </summary>
    /// <param name="message">Message à communiquer.</param>
    /// <returns>Message embelli.</returns>
    public string Communiquer(string message) => $"✨🌟 {message} 🌟✨";
}

using Modeles.Interfaces;

namespace Modeles.Entites.Astres;

/// <summary>
/// Représente un astre capable d'embellir les communications.
/// </summary>
public class VerbaAstre : Astre, ICommunication
{
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
    public string Communiquer(string message) =>
        $"✨🌟 {message} 🌟✨";
}
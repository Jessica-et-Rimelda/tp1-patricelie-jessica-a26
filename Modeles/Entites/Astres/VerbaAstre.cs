using Modeles.Interfaces;

namespace Modeles.Entites.Astres;

/// <summary>
/// Représente un astre capable d'embellir les communications.
/// </summary>
public class VerbaAstre : Astre, ICommunication

{ ///<summary> Initialise une nouvelle instance de la classe <see cref="VerbaAstre"/>.
  /// Constructeur.
  /// </summary>
  /// <param name="Nom">Le nom de l'entite.</param>/// 
  /// <param name="PositionX">La position sur l'axe des x.</param>/// 
  /// <param name="PositionY">La position sur l'axe des y.</param>/// 
    public VerbaAstre(
        string Nom,
        int PositionX,
        int PositionY)
        : base(Nom, PositionX, PositionY)
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